using System;
using System.Drawing;
using System.Windows.Forms;

namespace WEEK04_03_01
{
    public partial class Form1 : Form
    {
        //argb컬러 값을 get/set 하기 위해 System.Drawing.Color의 Object 선언.
        Color clr = new Color();

        //Apply Button의 using 여부에 대한 bool대수
        bool useApply = false;

        //메인 Button내 Text의 현재 Align 변경 Method
        private void AlignChanged(object sender, EventArgs e)
        {
            if (useApply == false)
            {
                RadioButton R = sender as RadioButton;
                if (R == textLeft) mainButton.TextAlign = ContentAlignment.MiddleLeft;
                if (R == textCenter) mainButton.TextAlign = ContentAlignment.MiddleCenter;
                if (R == textRight) mainButton.TextAlign = ContentAlignment.MiddleRight;
            }
        }

        //메인 Button을 Disalbe하는 CheckBox
        private void banButton_CheckedChanged(object sender, EventArgs e)
        {

            if (((CheckBox)sender).Checked) mainButton.Enabled = false;
            else mainButton.Enabled = true;
        }

        //Button을 Hide하는 CheckBox
        private void hideButton_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked) mainButton.Visible = false;
            else mainButton.Visible = true;
        }

        //Reset Button의 동작 Method
        private void resetButton_Click(object sender, EventArgs e)
        {
            //Align을 지정하는 Radio Button의 값을 False로 바꿈.
            if (textLeft.Checked) textLeft.Checked = false;
            else if (textRight.Checked) textRight.Checked = false;
            else if (textCenter.Checked) textCenter.Checked = false;

            //BackColor를 modifying하는 Group내부 Control들의 값을 초기화
            redTrackBar.Value = 0;
            greenTrackBar.Value = 0;
            blueTrackBar.Value = 0;
            redValue.Text = "0";
            greenValue.Text = "0";
            blueValue.Text = "0";

            //Value가 모두 Reset(없거나 default 값)이 된 후, Main Button 초기화
            mainButton.BackColor = SystemColors.Control;
            mainButton.TextAlign = ContentAlignment.MiddleCenter;
        }

        //exit 버튼
        private void exitForm_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Apply 버튼 Using 여부에 대한 CheckBox
        private void boolApply_CheckedChanged(object sender, EventArgs e)
        {
            //sender == Checkbox
            if (((CheckBox)sender).Checked)
            {
                applyBtn.Enabled = true;
                useApply = true;
                Refresh();
            }
            else
            {
                applyBtn.Enabled = false;
                useApply = false;
                Refresh();
            }
        }

        //ApplyButton
        private void applyBtn_Click(object sender, EventArgs e)
        {
            //Apply 시, AlignCheaned()하기 위해 useApply를 일시적으로 False
            useApply = false;
            //mainButton의 BackColor는 System.Drawing.Color타입의 object임.
            mainButton.BackColor = clr;

            //obj에 text align 상태에 따라 Radio button 객체 또는 null을 저장.
            object obj = textLeft.Checked ? textLeft : textCenter.Checked ? textCenter : textRight.Checked ? textRight : null;
            if(obj != null)
                AlignChanged(obj, e);
            useApply = true;
        }

        //폼 Cloing 시 띄울 MessageBox
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("종료하시겠습니까?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        //ColorTrackBar가 Scroll됐을 경우의 methods
        private void colorTrackBar_Scroll(object sender, EventArgs e)
        {
            //TrackBar의 value 변경시, TextBox의 value도 set
            setTextBox(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);
            //clr object에 ARGB값을 반영
            clr = Color.FromArgb(redTrackBar.Value, greenTrackBar.Value, blueTrackBar.Value);

            //Apply 버튼이 disable일 때 mainButton의 color를 즉시 modify
            if(useApply == false)
                mainButton.BackColor = clr;
        }

        //color를 지정하는 TextBox의 값이 변경 시.
        private void valueTextBox_Changed(object sender, EventArgs e)
        {
            //value를 변경한 textbox가 sender로 전달. 객체를 TextBox 형으로 전달.
            TextBox text = sender as TextBox;
            //TrackBar형의 object에 변경된 textbox 객체에 따라 해당 color의 trackbar 객체 전달
            TrackBar track = text == redValue ? redTrackBar : text == greenValue ? greenTrackBar : blueTrackBar;
            //i에 trackbar의 값(0~255)을 전달
            int i = track.Value;

            //textbox의 value가 null이지 않을 경우
            if(text.Text != "")
            {
                ///String을 Int32로 바꾸는 경우, string에 char가 있을 경우, system에서 FormatException이 발생.
                ///=>변환 시 문자열의 Format이 int와 맞지 않으면 Exception 발생.
                try
                {
                    //text를 Int32로 변환 시도
                    i = Int32.Parse(text.Text);
                } catch(FormatException)
                {
                    //Exception 발생 == Digit 외 char형태의 요소가 있음. => 예외처리 후, MessageBox 실행
                    MessageBox.Show("문자를 입력할 수 없습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
                } finally
                {
                    //Exception 발생 여부과 무관, i값이 0~255 사이 값이면 해당 값 적용
                    if (i >= 0 && i <= 255)
                    {
                        track.Value = i;
                    }
                }
            }
            
            //Apply 버튼이 disable이면 즉시 apply
            if(useApply == false)
                mainButton.BackColor = clr;
        }

        //Main Button 클릭 시
        private void mainButton_Click(object sender, EventArgs e)
        {
            //BackColor의 ARGB값에서 Alpha를 제외한 RGB value만 Slicing.
            string btnColor = "#" + clr.Name.ToUpper().Substring(2);
            //현재 text의 align확인
            string btnAlign = mainButton.TextAlign == ContentAlignment.MiddleLeft ? "왼쪽" : mainButton.TextAlign == ContentAlignment.MiddleCenter ? "가운데" : "오른쪽";
            //MessageBox에 현재 state를 출력
            MessageBox.Show("현재 버튼색은 " + btnColor + ", " + btnAlign + "정렬입니다\n", "버튼", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        public Form1()
        {
            //Form실행수 initailizing.
            InitializeComponent();

            //처음에 선언한 Color형 clr 객체에 main Button의 현재 BackColor와 동기화
            clr = mainButton.BackColor;
            setTrackBar(clr.R, clr.G, clr.B);
            setTextBox(clr.R, clr.G, clr.B);
        }

        //trackbar의 state 변경
        private void setTrackBar(int r, int g, int b)
        {
            redTrackBar.Value = r;
            greenTrackBar.Value = g;
            blueTrackBar.Value = b;
        }

        //color 값의 textBox의 value 변경
        private void setTextBox(int r,int g,int b)
        {
            redValue.Text = r.ToString();
            greenValue.Text = g.ToString();
            blueValue.Text = b.ToString();
        }
    }
}
