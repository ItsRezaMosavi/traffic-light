namespace traffic_light
{
    public partial class Form1 : Form
    {
        int Clock = 0;
        int Red_Time = 5;
        int Green_Time = 3;
        int Yellow_Time = 2;
        string color = "green";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tmrMain_Tick(object sender, EventArgs e)
        {
            Clock++;


            if (Red_Time == Clock && color == "red")
            {
                Clock = 0;
                color = "green";

                //???? ?? ??? ?????? ? ????? ?? ????

                btnLeftRed.BackColor = btnRightRed.BackColor = btnUpYellow.BackColor = btnDownYellow.BackColor = Color.White;
                btnLeftGreen.BackColor = btnRightGreen.BackColor = Color.Green;
                btnUpRed.BackColor = btnDownRed.BackColor = Color.Red;

               // btnUpYellow.BackColor = btnDownYellow.BackColor = Color.White;

            }



            else if (Green_Time == Clock && color == "green")
            {
                Clock = 0;
                color = "yellow";

                //???? ?? ??? ?????? ? ????? ?? ???? ?? ?????

                btnLeftGreen.BackColor = btnRightGreen.BackColor = Color.White;
                btnLeftYellow.BackColor = btnRightYellow.BackColor = Color.Yellow;
            }



            else if (Yellow_Time == Clock && color == "yellow")
            {
                Clock = 0;
                color = "red";
                //???? ?? ???? ?????? ? ????? ?? ???

                btnLeftYellow.BackColor = btnRightYellow.BackColor = btnUpRed.BackColor = btnDownRed.BackColor = Color.White;
                btnLeftRed.BackColor = btnRightRed.BackColor = Color.Red;
                btnUpGreen.BackColor = btnDownGreen.BackColor = Color.Green;

                //btnUpRed.BackColor = btnDownRed.BackColor = Color.White;
            }


            else if (Green_Time == Clock && color == "red")
            {
                //???? ??? ??? ???? ??? ????? ? ???? ????? ???? ??? ????

                btnUpGreen.BackColor = btnDownGreen.BackColor = Color.White;
                btnUpYellow.BackColor = btnDownYellow.BackColor = Color.Yellow;
            }
        }
    }
}
