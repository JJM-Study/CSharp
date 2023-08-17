using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common;

namespace Project
{

    public partial class Form_Pic : Form
    {


        List<int> Img_List = null; // jpg 파일에 적힌 노트들의 고유번호를 담는 리스트.

        static string ImgPath;

        Image[] MainImg = new Image[2]; // picImg 픽쳐박스 내에 넣을 이미지 경로\이미지 이름  // 0일 때 프로필, 1일 때, Main 이미지 
        OpenFileDialog ofd;

        int c_Img = 0;

        string FileExixt = ""; // 0일 때 프로필, 1일 때, Main 이미지

        public Form_Pic()
        {
            InitializeComponent();
        }

        private void Form_Pic_Load(object sender, EventArgs e)
        {
            ImgPath = Application.StartupPath + "\\Note" + "\\ImageFolder" + "\\Note" + "[" + lblChNum.Text + "]";

            CheckFolder();

            Count_Img();
            txtMImgFilePath.Text = ImgPath + "\\Note_" + lblCPage.Text + ".jpg";
            txtPfImgFilePath.Text = ImgPath + "\\Note_" + "Main" + ".jpg";

            Insert_Image();
        }

        private void CheckFolder() //
        {

            if (!Directory.Exists(ImgPath))
            {
                Directory.CreateDirectory(ImgPath); // 폴더 생성

            }

        }


        private void Insert_Image()
        {

            Image P_ImgOri;
            Image M_imgOri;

            if (picPfimgBox.Image != null)
            {
                picPfimgBox.Image.Dispose();
                picPfimgBox.Image = null;
            }
            if (picImgBox.Image != null)
            {
                picImgBox.Image.Dispose();
                picImgBox.Image = null;
            }


            if (Base.FileExistsCheck(txtPfImgFilePath.Text))
            {
                using (FileStream fsIn = new FileStream(txtPfImgFilePath.Text, FileMode.Open, FileAccess.Read, FileShare.Read)) // 단순 Image 형식으로 이미지 불러올 시 에러 메세지 발생하므로 FileStream 사용.
                {
                    Image source = Image.FromStream(fsIn);

                    Bitmap bitmap = new Bitmap(source);

                    MainImg[0] = bitmap;

                    P_ImgOri = MainImg[0].Clone() as Image;

                    MainImg[0].Dispose();
                    MainImg[0] = null;

                    picPfimgBox.Image = P_ImgOri;
                }
            }
            else
            {
                picPfimgBox.Image = Properties.Resources.Add_Image;
            }


            if (Base.FileExistsCheck(txtMImgFilePath.Text))
            {
                using (FileStream fsIn = new FileStream(txtMImgFilePath.Text, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    Image source = Image.FromStream(fsIn);
    
                    Bitmap bitmap = new Bitmap(source);

                    MainImg[1] = bitmap;

                    M_imgOri = MainImg[1].Clone() as Image;

                    MainImg[1].Dispose();
                    MainImg[1] = null;

                    picImgBox.Image = M_imgOri;
                }
            }
            else
            {
                picImgBox.Image = Properties.Resources.Add_Image;
            }

        }

    


        private void Count_Img()
        {

            TabPage tp;
            c_Img = 0;
            Img_List = new List<int>();
     
            foreach (string File in Directory.GetFiles(ImgPath, "*Note_*").OrderBy(f => f)) // 해당 페이지의 메인 이미지 탐색 및 파일 개수 검색. // 2022/01/09
            {

                string t_FName = Path.GetFileName(File); // 확장자를 포함한 파일명 가져오기

                string t_num_filter1 = t_FName.Replace("Note_", ""); //str에 문자열 중 페이지 정보를 ""공백문자로 대체

                //string t_num_filter2 = Regex.Replace(temp1, @"\D", ""); //str에 문자열 중 일반 문자를 ""공백문자로 대체
                string t_num_filter2 = t_num_filter1.Replace(".jpg", ""); //str에 문자열 중 일반 문자를 ""공백문자로 대체

                int temp = 0;
                bool num = int.TryParse(t_num_filter2, out temp); // 정수 여부 판별 trypase의 반환 형식 true, false

                if (num == true && temp > 0)
                {
                    c_Img++;
                    Img_List.Add(temp);

                    //ImageList.Add(temp); //이미지 카운트


                    //if (c_Img > 1)
                    if (c_Img == tabImgTab.TabCount)
                    {
                        
                        string PageName = string.Format("Image_{0}", c_Img + 1); // 그리드뷰를 넣고 이름이 그리드뷰의 고유번호나 타이틀을 따라가도록 하는 방법도 생각.
                        tp = new TabPage(PageName);

                        tabImgTab.TabPages.Add(tp);

                    }

                }


                // 페이지_Cnt end
            }

            Img_List.Sort();

            int i = 0;
            foreach (int List in Img_List)
            {
                i++;

                if (!Base.FileExistsCheck(ImgPath + "\\Note_" + i + ".jpg"))
                {
                    string oldFilePath = ImgPath + "\\Note_" + List + ".jpg";
                    string newFilePath = ImgPath + "\\Note_" + i + ".jpg";

                    System.IO.File.Move(oldFilePath, newFilePath);
                }
            }

            lblLPage.Text = (c_Img > 0 ? (c_Img + 1).ToString() : "1");

            tabImgTab.SelectedTab = tabImgTab.TabPages[0];

        }


        public string ShowFileOpenDialog()
        {

            ofd = new OpenFileDialog();
      
            ofd.Filter = "Image File (*.jpg, *.png, *.bmp) | *.jpg; *.png; *.bmp";

            DialogResult dr = ofd.ShowDialog();

            if (dr == DialogResult.OK)
            {

                if (FileExixt == "0") // 프로필
                {

                    MainImg[0] = Image.FromFile(ofd.FileName);

                    picPfimgBox.Image = MainImg[0];

                    return ofd.FileName; // 파일 경로 및 파일명 리턴

                }
                else if (FileExixt == "1") // 메인 이미지
                {

                    MainImg[1] = Image.FromFile(ofd.FileName);

                    picImgBox.Image = MainImg[1];

                    return ofd.FileName; // 파일 경로 및 파일명 리턴
                }
            }

            return "";

        }

        private void tabImg_Selected(object sender, TabControlEventArgs e)
        {

            lblCPage.Text = (tabImgTab.SelectedIndex + 1).ToString();


            txtMImgFileFullName.Text = "Note_" + lblCPage.Text + ".jpg";
            txtMImgFilePath.Text = ImgPath + "\\Note_" + lblCPage.Text + ".jpg";

            Insert_Image(); // 이미지 초기화
            
            if (tabImgTab.SelectedTab != null)
                tabImgTab.SelectedTab.Controls.Add(picImgBox);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (MainImg[0] != null) // 다이얼로그 등으로 새로운 프로필 이미지를 가져온 상태인지.
            {

                if (Base.FileExistsCheck(txtPfImgFilePath.Text))
                {

                    File.Delete(txtPfImgFilePath.Text);

                }

                MainImg[0].Save(ImgPath + "\\Note_" + "Main" + ".jpg");

            }

            if (MainImg[1] != null) // 다이얼로그 등으로 새로운 메인 이미지를 가져온 상태인지.
            {

                if (Base.FileExistsCheck(txtMImgFilePath.Text))
                {

                    File.Delete(txtMImgFilePath.Text);

                }

                MainImg[1].Save(ImgPath + "\\Note_" + lblCPage.Text + ".jpg");

            }

            for (int i =0 ; i <= 1; i++)
            {
                if (MainImg[i] != null)
                {
                    MainImg[i].Dispose(); // 메모리 관리
                    MainImg[i] = null;
                }
            }

            Insert_Image();

            MessageBox.Show("저장되었습니다.");

            Count_Img();

        }

        private void picPfimgBox_Click_1(object sender, EventArgs e)
        {
            FileExixt = "0";
            ShowFileOpenDialog();
        }

        private void picImgBox_Click(object sender, EventArgs e)
        {
            FileExixt = "1";
            ShowFileOpenDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Base.FileExistsCheck(txtMImgFilePath.Text))
            {
                if (MessageBox.Show("현재 탭의 이미지를 삭제하겠습니까?", "YesNO", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(txtMImgFilePath.Text);
                    tabImgTab.TabPages.RemoveAt(tabImgTab.TabCount - 1);
                    if(tabImgTab.TabCount <= 1)
                    {
                        picImgBox.Image = Properties.Resources.Add_Image;
                    }
                }
            }
            else
            {
                MessageBox.Show("이미지 파일이 없는 탭입니다.");
            }

            Count_Img();

        }
    }
}
