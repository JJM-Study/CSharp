using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO; //2021-07-18

using IniParser; // FileIniDataParser 을 위한 것.
using IniParser.Model; // IniData 을 위한 것.
using System.Diagnostics;
using System.Text.RegularExpressions;
using Common;


namespace Project
{

    public partial class Form1 : Form
    {

        #region 프로퍼티
        string IniFilePath;

        public string initFilePath
        {
            get { return Base.IniFilePath; }
        }

        #endregion

        enum list_grid
        {

        }

        enum detail_grid
        {
            title, //0
            memo   //1
        }

        enum hd_grid
        {
            num,  //0
            title,   //1
            rtfpath, //2
            txtpath, //3
            imgpath  //4
        }
        

        int c_sec = 0; // 정수 섹션의 총 갯수를 입력 받기 위한 함수.
        int CurrentPage = 1;

        List<int> txt_List = null; // txt 파일에 적힌 노트들의 고유번호를 담는 리스트.
        static string TextPath = Application.StartupPath + "\\Note" + "\\TextFolder";
        static string ImgPath = Application.StartupPath + "\\Note" + "\\ImageFolder";

        DirectoryInfo TxtFolderPath = new DirectoryInfo(TextPath);
        DirectoryInfo ImgFolderPath = new DirectoryInfo(ImgPath);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dtgList.SelectionMode = DataGridViewSelectionMode.FullRowSelect; // 셀 클릭 시 전체 선택하게 하는 기능.
            cmsContextMenuStrip.Items.Insert(4, new ToolStripSeparator()); // 우클릭 시 나타나는 컨텍스트메뉴 구분선
            ReadingInformation();
        }

        private void txtMemo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Init() // 초기화
        {
          //string InitTextPath = Application.StartupPath + "\\TextFolder\\Note[1].rtf"; // 경로 내 텍스트가 없을 시 임시 텍스트 파일 설정
            string InitTextPath = Application.StartupPath + "\\Note" + "\\TextFolder\\Note[1].rtf"; // 경로 내 텍스트가 없을 시 임시 텍스트 파일 설정

            if (TxtFolderPath.Exists == false)
            {
                TxtFolderPath.Create(); // 폴더 생성
                StreamWriter SW = File.CreateText(InitTextPath); // 텍스트 파일 생성
                SW.Close();
                
            }

        }

        private bool Check_Note_Num(int CheckType) // 0 = 중복되지 않는 최소 값을 대입, 1 = 고유번호 중복 알림.
        {
            if (CheckType == 0)
            {
                int i = 0;

                do
                {
                    i += 1;
                    if (txt_List.Count == i)
                    {
                        nudInput_NtNum.Value = txt_List[txt_List.Count - 1] + 1;
                        return true;
                    }
                    else if (txt_List[i - 1] == i && txt_List[i] != i + 1)
                    {
                        nudInput_NtNum.Value = i + 1;
                        return true;
                    }

                }
                while (true);
            }
            else // CheckType == 1
            {
                if (dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.num].Value.ToString() == nudInput_NtNum.Value.ToString()) // 고유번호 수정 여부
                {
                    return true;
                }

                int i = 1;
                while (true)
                {

                   if (txt_List[i - 1] == nudInput_NtNum.Value)
                   {

                        if (MessageBox.Show("[" + nudInput_NtNum.Value + "](" + dtgHdnInfo.Rows[i - 1].Cells[(int)hd_grid.title].Value + ") : 이미 존재하는 노트 번호입니다.\n\n노트 번호 : [" + dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.num].Value + "](" + dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.title].Value + ")와 교환하시겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            txtSaveMode.Text = "1"; // 교환할 데이터가 있으면서 고유번호 수정
                            
                            return true;
                        }
 
                        return false;
                   }
                   else if(txt_List[txt_List.Count - 1] == txt_List[i - 1])
                   {
                        if (Base.FileExistsCheck(TextPath + "\\Note" + "[" + nudInput_NtNum.Value + "].rtf"))
                        {
                            return true;
                        }
                        else
                        {
                            txtSaveMode.Text = "2"; // 교환할 데이터가 없으면서 고유번호 수정
                            return true;
                        }
                   }
                   i = i + 1;
                }
            }
        }

        private void GrIdVIew(int section)
        {
            if (dtgList.RowCount < txt_List.Count)
            {
                dtgList.Rows.Add();
                dtgHdnInfo.Rows.Add();
            }

            //dtgList - 0 : 고유번호, 1 : 이름
            //gtgHdnInfo - 0 : 오리지날 고유번호, 1 : 오리지날 이름, 2.파일경로(txtTextFilePath), 3. 세부정보 txt파일 경로, 4. 이미지 폴더 경로

            dtgList.Rows[c_sec].Cells[(int)hd_grid.num].Value = section.ToString(); // 고유번호

            dtgHdnInfo.Rows[c_sec].Cells[(int)hd_grid.num].Value = section.ToString(); // 원래 번호

            dtgHdnInfo.Rows[c_sec].Cells[(int)hd_grid.rtfpath].Value = TextPath + "\\Note" + "[" + dtgList.Rows[c_sec].Cells[(int)hd_grid.num].Value.ToString() + "].rtf";  // Note[n].rtf

            dtgHdnInfo.Rows[c_sec].Cells[(int)hd_grid.txtpath].Value = TextPath + "\\Note" + "[" + dtgList.Rows[c_sec].Cells[(int)hd_grid.num].Value.ToString() + "].txt";  // Note[n].txt . 세부 정보를 가져오기 위함.

            string[] textValue = System.IO.File.ReadAllLines(dtgHdnInfo.Rows[c_sec].Cells[(int)hd_grid.txtpath].Value.ToString());

            dtgHdnInfo.Rows[c_sec].Cells[(int)hd_grid.title].Value = textValue[0];
            dtgList.Rows[c_sec].Cells[(int)hd_grid.title].Value = textValue[0];

            string temp_ImgPath = Application.StartupPath + "\\Note" + "\\ImageFolder\\Note" + "[" + dtgHdnInfo.Rows[c_sec].Cells[(int)hd_grid.num].Value.ToString() + "]";

            dtgHdnInfo.Rows[c_sec].Cells[(int)hd_grid.imgpath].Value = temp_ImgPath; // 이미지 폴더 경로

        }

        private void ReadingInformation() // txt 파일을 읽는 방법.
        {


            if (!Base.FileExistsCheck(TextPath)) // 경로에 폴더가 없을 경우 폴더 생성
              {
                  TxtFolderPath.Create(); // 폴더 생성
              }

            var parser = new FileIniDataParser();


              c_sec = 0;
              int c_txt = 0;

              txt_List = new List<int>();

              foreach (string File in Directory.GetFiles(TextPath, "Note" + "[*").OrderBy(f => f)) // 해당 페이지의 텍스트 파일 개수 검색. // 2022/01/09
              {

                  string t_FName = Path.GetFileName(File); // 확장자를 포함한 파일명 가져오기

                  string t_num_filter1 = t_FName.Replace("Note[", ""); //str에 문자열 중 페이지 정보를 ""공백문자로 대체

                  string t_num_filter2 = t_num_filter1.Replace("].rtf", ""); //str에 문자열 중 일반 문자를 ""공백문자로 대체   // 향후 정규식 등 방법으로 더 간편화 할 수 있는 지 알아볼 것.

                  int temp = 0;
                  bool num = int.TryParse(t_num_filter2, out temp); // 정수 여부 판별 trypase의 반환 형식 true, false

                if (num == true && temp > 0)
                  {
                      c_txt++;
                      txt_List.Add(temp);

                  }


              }

              if (txt_List.Count == 0)
              {
                  if (!Base.FileExistsCheck(TextPath + "\\Note[1].txt"))
                  {
                      TextWriter TW = new StreamWriter(TextPath + "\\Note[1].txt");
                      TW.WriteLine("이름없음");
                      TW.WriteLine();
                      TW.Close();
                      txt_List.Add(1); // 2022/05/08 추가
                  }
                  if (!Base.FileExistsCheck(TextPath + "\\Note[1].rtf"))
                  {
                      rtxMemo.Text = "";
                      rtxMemo.SaveFile(TextPath + "\\Note[1].rtf");
                  }
              }
              
              txt_List.Sort(); // 리스트 내의 섹션 값을 오름차순 정렬.

              // 이하 foreach (xxx in Sec_List) 하여 위의 고유번호, 이름, 세부내용을 순차적으로 가져오도록.
              dtgList.Rows.Clear();
              dtgHdnInfo.Rows.Clear();

              foreach (var section in txt_List)
              {

                  //dtgList - 0 : 고유번호, 1 : 이름
                  //dtgHdnInfo - 0 : 오리지날 고유번호, 1 : 오리지날 이름, 2.파일경로(txtTextFilePath), 3. 세부정보 txt파일 경로, 4. 이미지 폴더 경로
                  GrIdVIew(section); // 그리드뷰 처리 함수

                c_sec++;

                  if (c_sec == CurrentPage)
                  {
                    
                      nudInput_NtNum.Value = Convert.ToInt32(section);


                     if (!Base.FileExistsCheck(dtgHdnInfo.Rows[c_sec-1].Cells[3].Value.ToString())) // 이름 등 세부내용 파일이 존재하지 않을 경우
                      {
                        //StreamWriter SW = new StreamWriter(txtDetailTextPath.Text);
                          StreamWriter SW = new StreamWriter(dtgHdnInfo.Rows[c_sec-1].Cells[3].Value.ToString());
                          SW.WriteLine("이름없음\n");
                          SW.Close();
                      }

                      if (!Base.FileExistsCheck(dtgHdnInfo.Rows[c_sec-1].Cells[2].Value.ToString())) // 해당 제목의 세부내용 파일이 없을 경우.
                      {
                          rtxMemo.SaveFile(dtgHdnInfo.Rows[c_sec-1].Cells[2].Value.ToString());
                      }

                      if (rtxMemo.Rtf.Length == 0)
                      {
                          rtxMemo.Text = "";
                      }


                      StreamReader SR = new StreamReader(dtgHdnInfo.Rows[c_sec-1].Cells[(int)hd_grid.txtpath].Value.ToString()); // 세부정보 텍스트 파일 열기
          

                      rtxMemo.LoadFile(dtgHdnInfo.Rows[c_sec-1].Cells[(int)hd_grid.rtfpath].Value.ToString()); // rtx 파일 불러오기

                      txtName.Text = dtgHdnInfo.Rows[c_sec-1].Cells[(int)hd_grid.title].Value.ToString();


                      SR.Close(); // StreamReader 닫기. 


                      this.ActiveControl = rtxMemo; // 텍스트 자체에 포커스가 가게 하도록 하는 것.
                      rtxMemo.Focus();

                      rtxMemo.SelectionStart = rtxMemo.TextLength; // focus가 텍스트 박스의 마지막 문장에 가도록 하는 로직.

                      rtxMemo.ScrollToCaret();



                    //----세부정보 그리드뷰 정보 기입-----

                    dtgDetail_Info.Rows.Clear();

                    string[] textValue = System.IO.File.ReadAllLines(dtgHdnInfo.Rows[CurrentPage-1].Cells[(int)hd_grid.txtpath].Value.ToString());
                    int row = 0;

                    for (int i = 2; i < textValue.Length - 1; i = i+2) // 이름(1~2줄)을 제외하고 세부정보를 한 줄씩 읽어온다. //https://infodbbase.tistory.com/113
                    {                 
                        dtgDetail_Info.Rows.Add();

                        dtgDetail_Info.Rows[row].Cells[(int)detail_grid.title].Value = textValue[i];
                        dtgDetail_Info.Rows[row].Cells[(int)detail_grid.memo].Value = textValue[i+1];

                        row++;
                    }
                    //-----------------------------



                    Image P_ImgOri; // 프로필 이미지 불러오기.

                      if (picPfimgBox.Image != null)
                      {
                          picPfimgBox.Image.Dispose();
                          picPfimgBox.Image = null;
                      }


                      string PfImgFilePath = dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value + "\\Note_Main.jpg";

                      if (Base.FileExistsCheck(PfImgFilePath))
                      {

                          using (FileStream fsIn = new FileStream(PfImgFilePath, FileMode.Open, FileAccess.Read, FileShare.Read)) // 단순 Image 형식으로 이미지 불러올 시 에러 메세지 발생하므로 FileStream 사용.
                          {
                              Image source = Image.FromStream(fsIn);

                              Bitmap bitmap = new Bitmap(source);

                              P_ImgOri = bitmap.Clone() as Image;

                              picPfimgBox.Image = P_ImgOri;

                              bitmap.Dispose();
                              bitmap = null;

                          }
                      }
                      else
                      {
                          picPfimgBox.Image = Properties.Resources.Add_Image;
                      }

                  }
              }


              dtgList.CurrentCell = dtgList.Rows[CurrentPage - 1].Cells[0];
              txtSaveMode.Text = ""; // 새로 만들기 모드 취소.
              lblCPage.Text = CurrentPage.ToString();
              lblLPage.Text = c_sec.ToString(); // 총 페이지

        }
       
        // 저장할 때 ini의 Section, Name값과 텍스트 파일의 Note[i]_Name 의 I와 Name 등 이름을 비교해서 해당 파일의 Name 부분을 수정하는 방법을 쓸 것.

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtName.Text == "")
            {
                MessageBox.Show("이름을 입력하셔야 합니다.");
                txtName.Focus();
                return;
            }

            if (nudInput_NtNum.Value <= 0) // 나중에 중복되지 않는 일련번호를 자동으로 집어넣는 방식 구현할 것.
            {
                MessageBox.Show("1이상의 값을 입력해야 합니다.");
                return;
            }

            txtTextFilePath.Text = TextPath + "\\Note" + "[" + nudInput_NtNum.Value + "].rtf"; // 메모 내용
            txtDetailTextPath.Text = TextPath + "\\Note" + "[" + nudInput_NtNum.Value + "].txt"; // 이름 등 세부 내용
            txtImgFolderPath.Text = ImgPath + "\\Note" + "[" + nudInput_NtNum.Value + "]"; // 이미지 폴더 경로

            StreamWriter SW; // 세부정보

            if (txtSaveMode.Text == "0") // New 노트 정보 생성.
            {
                SW = new StreamWriter(txtDetailTextPath.Text);
                SW.Write(txtName.Text + "\n"); // 세부내용 메모장에 이름 기입
                SW.Close();

                rtxMemo.SaveFile(txtTextFilePath.Text);
            }

            if (Check_Note_Num(1))
            {
                if (txtName.Text != dtgHdnInfo.Rows[CurrentPage - 1].Cells[1].Value.ToString() && txtSaveMode.Text != "0") // 노트 이름 변경.
                {
                    if (MessageBox.Show("노트 이름을 수정하겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.No)
                    {

                        return;

                    }
                }


                Base.WriteInformation(txtSaveMode.Text, "Name", txtName.Text, Base.IniFilePath); // 다운로드 경로를 저장할 ini 파일 생성   // key값을 enum 방식으로 사용, 반복문으로 간단화 하는 방식 고민.
                Base.WriteInformation(txtSaveMode.Text, "TxtPath", txtTextFilePath.Text, Base.IniFilePath);

                //-------------------세부내용 텍스트 파일 쓰기 ------------------------

                if ((txtSaveMode.Text == "" ? 0 : Int32.Parse(txtSaveMode.Text)) > 0 && (txtSaveMode.Text == "" ? 0 : Int32.Parse(txtSaveMode.Text)) < 3) // savemode가 1일 땐 고유번호를 수정.
                {

                    File.Delete(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.rtfpath].Value.ToString());
                    File.Delete(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.txtpath].Value.ToString());

                    if (txtSaveMode.Text == "1")
                    {
                        File.Move(txtTextFilePath.Text, dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.rtfpath].Value.ToString());
                        File.Move(txtDetailTextPath.Text, dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.txtpath].Value.ToString());


                        // 이미지 폴더 이름 교체

                        if (Directory.Exists(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString()))
                            Directory.Move(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString(), dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString() + "_temp");
                        if (Directory.Exists(txtImgFolderPath.Text))
                            Directory.Move(txtImgFolderPath.Text, txtImgFolderPath.Text + "_temp");
               
                        if (Directory.Exists(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString() + "_temp"))
                            Directory.Move(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString() + "_temp", txtImgFolderPath.Text);
                        if (Directory.Exists(txtImgFolderPath.Text + "_temp"))
                            Directory.Move(txtImgFolderPath.Text + "_temp", dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString());

                        //-------------------------

                    }
                    else if(txtSaveMode.Text == "2")
                    {
                        if(Directory.Exists(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString())) // 이미지 넘버 수정
                            Directory.Move(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString(), txtImgFolderPath.Text);
                    }
                }

                if ((txtSaveMode.Text == "" ? 0 : Int32.Parse(txtSaveMode.Text)) == 0)
                    File.Delete(txtDetailTextPath.Text);

                SW = new StreamWriter(txtDetailTextPath.Text);

                SW.WriteLine(txtName.Text + "\n"); // 세부내용에 이름 기입

                for (int row = 0; row < dtgDetail_Info.RowCount - 1; row++)
                {
                    if (dtgDetail_Info.Rows[row].Cells[0].Value != null || dtgDetail_Info.Rows[row].Cells[1].Value != null)
                    {
                        SW.WriteLine(dtgDetail_Info.Rows[row].Cells[0].Value);
                        SW.WriteLine(dtgDetail_Info.Rows[row].Cells[1].Value);
                    }
                }

                rtxMemo.SaveFile(txtTextFilePath.Text); // 메모 내용 기입

                SW.Close();

                txtSaveMode.Text = "";

                MessageBox.Show("저장이 완료되었습니다.");

                ReadingInformation();

            }

        }

        private void txtChNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (CurrentPage < c_sec)
            {
                CurrentPage++;
                //lblCPage.Text = CurrentPage.ToString();
                ReadingInformation();
            }
            else
            {
                MessageBox.Show("마지막 페이지입니다.");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (CurrentPage > 1)
            {
                CurrentPage--;
                lblCPage.Text = CurrentPage.ToString();
                ReadingInformation();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Check_Note_Num(0);

            txtSaveMode.Text = "0"; // 0은 저장할 때 새 노트 정보를 입력하겠다는 의미.
            
            // 기회되면 컨트롤 초기화 프레임 워크 만들어 볼 것.
            picPfimgBox.Image = Properties.Resources.Add_Image;
            txtName.Text = "";
            txtName.Focus();
            rtxMemo.Rtf = "";

            dtgDetail_Info.Rows.Clear();
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

            Form_Pic Child1 = new Form_Pic(); // 자식 Form으로 설정.

            Child1.Owner = this;

            Child1.lblChNum.Text = dtgHdnInfo.Rows[CurrentPage-1].Cells[0].Value.ToString();

            Child1.lblChName.Text = dtgHdnInfo.Rows[CurrentPage-1].Cells[1].Value.ToString();

            Child1.ShowDialog();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtSaveMode.Text != "0")
            {
                if (MessageBox.Show("No."+ dtgHdnInfo.Rows[CurrentPage].Cells[(int)hd_grid.num].Value + " : "+txtOri_Name.Text+" 정보가 삭제됩니다. 계속 하시겠습니까?" , "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // 옵션으로 어떤 번호의 노트를 삭제했을 때 그 뒤의 고유번호가 -1씩 되도록 하겠는지 여부 묻는 것 구현 고민.
                    // 관련 이미지도 다 삭제되게 됨.
                    // 이미지가 1개 이상 있을 경우 이미지도 사라진다는 경고문을 한번 더 줌.

                    if (Base.FileExistsCheck(dtgHdnInfo.Rows[CurrentPage-1].Cells[(int)hd_grid.rtfpath].Value.ToString()))
                    {
                        if (Directory.Exists(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString()))
                        {
                            if (MessageBox.Show("No." + dtgHdnInfo.Rows[CurrentPage].Cells[(int)hd_grid.num].Value + " : " + txtOri_Name.Text + " 이미지 파일을 포함하고 있습니다. 그래도 삭제 하겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                            {
                                File.Delete(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.rtfpath].Value.ToString()); // 관련 이미지 삭제 로직까지 다 구현하면 주석 풀 것.
                                File.Delete(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.txtpath].Value.ToString()); // 관련 이미지 삭제 로직까지 다 구현하면 주석 풀 것.
                                Directory.Delete(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.imgpath].Value.ToString(), true);
                                MessageBox.Show("삭제되었습니다.");

                                ReadingInformation();
                            }
                            
                        }
                        else
                        {
                            File.Delete(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.rtfpath].Value.ToString());
                            File.Delete(dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.txtpath].Value.ToString());
                            MessageBox.Show("삭제되었습니다.");

                            ReadingInformation();
                        }
                    }

                    
                }
            }
            else
            {
                MessageBox.Show("새로 만들기 모드에서는 삭제할 수 없습니다.");
            }
        }

        private void tsmiCut_Click(object sender, EventArgs e)
        {
            rtxMemo.Cut();//잘라내기
        }

        private void tsmiPaste_Click(object sender, EventArgs e)
        {
            rtxMemo.Paste();//붙여넣기
        }

        private void tsmiCopy_Click(object sender, EventArgs e)
        {
            rtxMemo.Copy(); //복사
        }

        private void tsmiSelectAll_Click(object sender, EventArgs e)
        {
            rtxMemo.SelectAll(); //모두 선택
        }

        private void tsmiFont_Click(object sender, EventArgs e)
        {
            if (fndFontDialog.ShowDialog() == DialogResult.OK)
                rtxMemo.SelectionFont = fndFontDialog.Font;
            //폰트 스타일 지정
        }

        private void tsmiColor_Click(object sender, EventArgs e) // 폰트색 지정
        {
            if (cldColorDialog.ShowDialog() == DialogResult.OK)
                rtxMemo.SelectionColor = cldColorDialog.Color;
        }

        private void dtgList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CurrentPage = dtgList.CurrentCell.RowIndex + 1;
            ReadingInformation();
        }

        private void btnSkill_Click(object sender, EventArgs e)
        {
            Form_Skill form_skill = new Form_Skill();

            form_skill.Owner = this;

            form_skill.lblChNo.Text = dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.num].Value.ToString();
            form_skill.lblName.Text = dtgHdnInfo.Rows[CurrentPage - 1].Cells[(int)hd_grid.title].Value.ToString();
            form_skill.lblName.Visible = true;
            form_skill.lblNlbl.Visible = true;
            form_skill.lblChNo.Visible = true;
            form_skill.lblCNlbl.Visible = true;

            form_skill.ShowDialog();
            



        }

        private void dtgDetail_Info_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && dtgDetail_Info.RowCount > 1 && dtgDetail_Info.SelectedRows.Count == 0 && dtgDetail_Info.CurrentRow.Index + 1 < dtgDetail_Info.RowCount)
            {
                if (MessageBox.Show("이 행을 지우겠습니까?", "YesOrNo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    dtgDetail_Info.Rows.RemoveAt(dtgDetail_Info.CurrentRow.Index);
                }
            }
        }

        private void btnMain_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<Main_Form>().Count() == 0)
                (new Main_Form()).Show();
        }

    }
}