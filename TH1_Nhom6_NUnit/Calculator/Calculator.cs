using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {
        pt h = new pt(); //khai bao lop chứa các hàm để sử dụng
        public bool clickBang = false;
        public double x, y,z, x1, x2,min;
        public double a1 = 0, b1 = 0, c1 = 0,d1=0, a2 = 0, b2 = 0, c2 = 0,d2=0,a3=0,b3=0,c3=0,d3=0;
        public double a = 0, b = 0, c = 0;
        public int mode = 1;
       
        public const double PI = 3.141592654;
        public const double E = 2.718281828;
            
        public bool CoKetqua = false;//Lưu trạng thái phím dấu =
        public bool Conhap = false;//Lưu trạng thái nhap so
        public bool CoPheptinh = false;//Lưu trạng thái phím Phép tính +,-,*,/
        public bool kiemtra = false;//Lưu trạng thái Tê liệt bàn phím 
        public string Pheptinh = "";//Lưu phép tính +,-,*,/
        public double Sohang1 = 0;//Lưu số hạng 1
        public double Sohang2 = 0;//Lưu số hạng 2 
       
        public bool CoTinhdon = false;
        
        public void Nhapso(string so)
        {
            if (!kiemtra )
            {
                if (CoKetqua) Sohang1 = double.Parse(txt_pheptinh.Text);
                if ((!CoKetqua) && (!Conhap)&&(!CoPheptinh))
                {//chưa bấm một trong các phím trên thì thực hiện viêc nối vào sau
                    if (txt_pheptinh .Text == "0") //đấu tiên là số 0
                        txt_pheptinh .Text = "";//thì xóa hắn đi
                    txt_pheptinh .Text = txt_pheptinh .Text + so;//sau đó nối vào bên phải
                }
                else//còn bấm rồi thì thay thế
                {
                    txt_pheptinh .Text = so;//thay thế
                    Conhap = false;
                    CoKetqua = false;
                    CoPheptinh = false;
                }
             //   CoTinhdon = false;
            }
        }

        public void Nhappheptinh (string pt)
        {
                txt_pheptinh .Text = double.Parse(txt_pheptinh .Text).ToString();
                //đưa về giá trị của màn hình vd nhập 0.100000 = 0.1
                if (CoTinhdon) Pheptinh = "";
                if ((Pheptinh!="") && (!CoPheptinh))
                    Tinhtoan();
                Sohang1 = double.Parse(txt_pheptinh .Text);//Lưu vào số hạng 1
                Pheptinh = pt;//gán vào biến pt(nhận các giá trị +,-,*,/
                CoKetqua = false;
                Conhap = false;
                CoTinhdon = false;
                CoPheptinh = true;
                
        }
        public void Tinhtoan()
        {
            txt_pheptinh .Text = double.Parse(txt_pheptinh.Text).ToString();
            double Ketqua;
            if (!CoKetqua)
                Sohang2 = double.Parse(txt_pheptinh.Text);
            if (Pheptinh == "+")
            {
                if (!CoKetqua)
                    Ketqua = Sohang1 + Sohang2;
                else
                    Ketqua = double.Parse(txt_pheptinh .Text) + Sohang2;
                txt_pheptinh.Text = Ketqua.ToString();
            }
            else
                if (Pheptinh == "-")
                {
                    if (!CoKetqua)
                        Ketqua = Sohang1 - Sohang2;
                    else
                        Ketqua = double.Parse(txt_pheptinh .Text) - Sohang2;
                    txt_pheptinh .Text = Ketqua.ToString();
                }
                else
                    if (Pheptinh == "*")
                    {
                        if (!CoKetqua)
                            Ketqua = Sohang1 * Sohang2;
                        else
                            Ketqua = double.Parse(txt_pheptinh .Text) * Sohang2;
                        txt_pheptinh .Text = Ketqua.ToString();
                    }
                    else
                        if (Pheptinh == "/")
                        {
                            if (Sohang2 != 0)//khác 0 mới thuc hien chia
                            {
                                if (!CoKetqua)
                                    Ketqua = Sohang1 / Sohang2;
                                else
                                    Ketqua = double.Parse(txt_pheptinh .Text) / Sohang2;
                                txt_pheptinh .Text = Ketqua.ToString();
                            }
                            else
                            {
                                txt_pheptinh .Text = "Không thể chia cho 0!";
                                kiemtra  = true;// khỏi bấm phím ngoài CE và C
                            }
                        }
            CoKetqua = true;
            CoPheptinh = false;
        }
        public Calculator()
        {
            InitializeComponent();
        }
        
        private void bt_0_Click(object sender, EventArgs e)
        {
            Nhapso("0");
        }
        private void bt_1_Click_1(object sender, EventArgs e)
        {
            Nhapso("1");
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            Nhapso("2");
        }
        

        private void bt_3_Click(object sender, EventArgs e)
        {
            Nhapso("3");
        }
        

        private void bt_4_Click(object sender, EventArgs e)
        {
            Nhapso("4");
        }
        

        private void bt_5_Click(object sender, EventArgs e)
        {
            Nhapso("5");
        }
        

        private void bt_6_Click(object sender, EventArgs e)
        {
            Nhapso("6");
        }
        

        private void bt_7_Click(object sender, EventArgs e)
        {
            Nhapso("7");
        }
        

        private void bt_8_Click(object sender, EventArgs e)
        {
            Nhapso("8");
        }
        

        private void bt_9_Click(object sender, EventArgs e)
        {
            Nhapso("9");
        }
              
        private void bt_cong_Click(object sender, EventArgs e)
        {
            if (!kiemtra ) Nhappheptinh("+");
        }
        private void bt_tru_Click(object sender, EventArgs e)
        {
            if (!kiemtra ) Nhappheptinh("-");
        }
        private void bt_nhan_Click(object sender, EventArgs e)
        {
            if (!kiemtra ) Nhappheptinh("*");
        }
        private void bt_chia_Click(object sender, EventArgs e)
        {
            if (!kiemtra ) Nhappheptinh("/");
        }
        public double tinhGT(double n)
        {
            if (n > 0)
                return n * tinhGT(n - 1);
            return 1;
        }
        public double mu2(double n)
        {
            return Math.Pow(n, 2);
        }
        private void bt_mu2_Click_1(object sender, EventArgs e)
        {
            txt_ketqua.Text = mu2(Convert.ToDouble(txt_pheptinh.Text)).ToString();
        }
           
        private void bt_giaithua_Click_1(object sender, EventArgs e)
        {
            txt_ketqua .Text = tinhGT(Convert.ToDouble(txt_pheptinh.Text)).ToString();
        }
        
        private void bt_cham_Click(object sender, EventArgs e)
        {
            txt_pheptinh.Text += ".";
            clickBang = false;
        }
        private void bt_bang_Click(object sender, EventArgs e)
        {
            
            //Tinh toan cong tru nhan chia
            if (mode == 1)
            {
                if (!kiemtra )
                {
                    Tinhtoan();
                    CoTinhdon = true;
                }
               
            }
            //giai he phuong trinh 2 an
            if(mode==2)
            {
                if (txt_ketqua.Text == "nhap a1")
                {
                    if (txt_pheptinh.Text == "")
                    {
                        a1 = 0;
                        return;
                    }
                    a1 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap b1";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap b1")
                {
                    if (txt_pheptinh.Text == "")
                    {
                        b1 = 0;
                        return;
                    }
                    b1 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap c1";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap c1")
                {
                    if (txt_pheptinh.Text == "")
                    {
                        c1 = 0;
                        return;
                    }
                    c1 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap a2";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap a2")
                {
                    if (txt_pheptinh.Text == "")
                    {
                        a2 = 0;
                        return;
                    }
                    a2 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap b2";
                    txt_pheptinh.Text = "";


                    return;
                }
                if (txt_ketqua.Text == "nhap b2")
                {
                    if (txt_pheptinh.Text == "")
                    {
                        b2 = 0;
                        return;
                    }
                    b2 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap c2";

                    txt_pheptinh.Text = "";

                    return;
                }
                if (txt_ketqua.Text == "nhap c2")
                {
                    if (txt_pheptinh.Text == "")
                    {
                        c2 = 0;
                        return;
                    }
                    c2 = double.Parse(txt_pheptinh.Text);
                    txt_pheptinh.Text = "";
                    txt_ketqua.Text = "";
                }
                txt_pheptinh.Text = h.GiaiHPTbacnhat2an(a1, b1, c1,a2, b2, c2, ref x, ref y);//gọi hàm trong lop pt.cs, h là lớp pt đã khai báo trước.
                txt_ketqua.Text = "";
                if (txt_pheptinh.Text == "Hệ phương trình có 1 nghiệm")
                    txt_ketqua.Text = "X=" + x.ToString() + "   " + "Y=" + y.ToString();
           }
            //Giai PT bac 2
            if (mode == 3)
            {
                if (txt_ketqua.Text == "nhap a")
                {
                    a = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap b";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap b")
                {
                    b = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap c";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap c")
                {
                    c = double.Parse(txt_pheptinh.Text);
                    txt_pheptinh.Text = "";
                }
                txt_pheptinh.Text = h.giaiPhuongTrinhBacHai(a, b, c, ref x1, ref x2);//gọi hàm trong lop pt.cs, h là lớp pt đã khai báo trước.
                txt_ketqua.Text = "";
                if (txt_pheptinh.Text == "Phương trình có 1 nghiệm")
                    txt_ketqua.Text = "X=" + x1.ToString();
                if (txt_pheptinh.Text == "Phương trình có 2 nghiệm")
                    txt_ketqua.Text = "X1=" + x1.ToString()+"   " + "X2=" + x2.ToString();

             }
            //Giai he phuong trinh bac nhat 3 an
            if (mode == 4)
            {
                if (txt_ketqua.Text == "nhap a1")
                {
                    a1 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap b1";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap b1")
                {
                    b1 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap c1";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap c1")
                {
                    c1 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap d1";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap d1")
                {
                    d1 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap a2";

                    txt_pheptinh.Text = "";

                    return;
                }
                if (txt_ketqua.Text == "nhap a2")
                {
                    a2 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap b2";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap b2")
                {
                    b2 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap c2";

                    txt_pheptinh.Text = "";

                    return;
                }
                if (txt_ketqua.Text == "nhap c2")
                {
                    c2 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap d2";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap d2")
                {
                    d2 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap a3";

                    txt_pheptinh.Text = "";

                    return;
                }
                if (txt_ketqua.Text == "nhap a3")
                {
                    a3 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap b3";
                    txt_pheptinh.Text = "";


                    return;
                }
                if (txt_ketqua.Text == "nhap b3")
                {
                    b3 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap c3";

                    txt_pheptinh.Text = "";

                    return;
                }
                if (txt_ketqua.Text == "nhap c3")
                {
                    c3 = double.Parse(txt_pheptinh.Text);
                    txt_ketqua.Text = "nhap d3";
                    txt_pheptinh.Text = "";
                    return;
                }
                if (txt_ketqua.Text == "nhap d3")
                {
                    d3 = double.Parse(txt_pheptinh.Text);
                    txt_pheptinh.Text = "";
                }
                txt_pheptinh.Text = h.GiaiHPTbacnhat3an(a1, b1, c1, d1, a2, b2, c2, d2, a3, b3, c3, d3, ref x, ref y, ref z);//gọi hàm trong lop pt.cs, h là lớp pt đã khai báo trước.
                txt_ketqua.Text = "";
                if (txt_pheptinh.Text == "Hệ phương trình có 1 nghiệm")
                    txt_ketqua.Text = "X=" + x.ToString() + "   " + "y=" + y.ToString()+ " " + "z="+ z.ToString ();
     
             }
        }



        public double Sin(double n)
        {
            return Math.Sin(Math.PI * n / 180);
        }
        private void bt_sin_Click(object sender, EventArgs e)
        {
            txt_ketqua.Text = Sin(Convert.ToDouble(txt_pheptinh.Text)).ToString();
        }
        public double Cos(double n)
        {
            return Math.Cos(Math.PI * n / 180);
        }
         
        private void bt_cos_Click(object sender, EventArgs e)
        {
            //txt_pheptinh.Text += "cos";
           txt_ketqua.Text =Cos(Convert.ToDouble(txt_pheptinh.Text)).ToString();
           
        }
         public double Tag(double n)
        {
            return Math.Sin(Math.PI * n / 180) / Math.Cos(Math.PI * n / 180);
        }
         
        
        private void bt_tan_Click(object sender, EventArgs e)
        {
            txt_ketqua.Text = Tag(Convert.ToDouble(txt_pheptinh.Text)).ToString();
        }
        public double Cotg(double n)
        {
            return Math.Cos(Math.PI * n / 180) / Math.Sin(Math.PI * n / 180);
        }
        private void btcotg_Click(object sender, EventArgs e)
        {
            txt_ketqua.Text = Cotg(Convert.ToDouble(txt_pheptinh.Text)).ToString();
        }

        private void bt_mode_Click(object sender, EventArgs e)
        {
           if (mode <= 4)
            {
                mode++;
                textBox2.Text = mode.ToString();
                if (mode == 5)
                {
                    mode = 1;
                    textBox2.Text = mode.ToString();
                }
            }
            
            if (mode == 1)
            {
                textBox4.Text = "Tinh Toan";
                txt_ketqua.Text = "";
                txt_pheptinh.Text = "";
            }
            if(mode==2)
            {
                textBox4.Text = "HPT bac nhat 2 an";
                txt_ketqua.Text = "nhap a1";
                txt_pheptinh.Text = "";
            }
            if(mode==3)
            {
                textBox4.Text = "Giai PT Bac 2";
                txt_ketqua.Text = "nhap a";
                txt_pheptinh.Text = "";
            }
            if (mode == 4)
            {
                textBox4.Text = "HPT bac nhat 3 an";
                txt_ketqua.Text = "nhap a1";
                txt_pheptinh.Text = "";
            }

       }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox2.Text="1";
            textBox4.Text="Tính Toán";
        }

        private void bt_doiDau_Click(object sender, EventArgs e)
        {
            if (!kiemtra )
            txt_pheptinh .Text = (-double.Parse(txt_pheptinh .Text)).ToString();
            //txt_pheptinh.Text += "-";
        }

        private void bt_ac_Click(object sender, EventArgs e)
        {
            clickBang = true;
            if (mode == 1)
            {
                txt_pheptinh.Text = "0";
                txt_ketqua.Text = "";
                CoKetqua = false;
                Conhap = false;
                CoPheptinh = false;
                kiemtra  = false;
                Pheptinh = "";
                Sohang1 = 0;
                Sohang2 = 0;
                
            }
            if (mode == 2)
            {
                txt_pheptinh.Text = "";
                txt_ketqua.Text ="nhap a1";
            }
            if (mode == 3)
            {
                txt_ketqua.Text ="nhap a";
                txt_pheptinh.Text = "";
            }
            if (mode == 4)
            {
                txt_ketqua.Text = "nhap a1";
                txt_pheptinh.Text = "";
            }

        }

        private void bt_DEL_Click(object sender, EventArgs e)
        {
            int l = txt_pheptinh.Text.Length;
            if (l > 0)
            {
               
                txt_pheptinh.Text = txt_pheptinh.Text.Remove(l - 1);
                return;
            }
            clickBang = false;
        }

        private void bt_min_Click(object sender, EventArgs e)
        {
            min = double.Parse(txt_pheptinh.Text);
            textBox3.Text = "M";
        }

        private void bt_mr_Click(object sender, EventArgs e)
        {
            if (clickBang == true) txt_pheptinh.Text = "";
            txt_pheptinh.Text = txt_pheptinh.Text + min.ToString();
           
            clickBang = false;
        }

        private void bt_pi_Click(object sender, EventArgs e)
        {
            txt_pheptinh.Text += PI.ToString();
            clickBang = false;
        }

        private void bt_exp_Click(object sender, EventArgs e)
        {
            txt_pheptinh.Text += E.ToString();
            clickBang = false;
        }
        private void bt_back_Click(object sender, EventArgs e)
        {
            txt_pheptinh.Select();
            SendKeys.Send("{LEFT}");
        }

        private void bt_next_Click(object sender, EventArgs e)
        {
            txt_pheptinh.Select();
            SendKeys.Send("{RIGHT}");
        }

        private void bt_off_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txt_pheptinh_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != '.')
                e.Handled = true;
            if (txt_pheptinh .Text.Contains(".") && (e.KeyChar == '.') && (txt_pheptinh .Text != ""))
                e.Handled = true;
            if (txt_pheptinh .Text == "" && e.KeyChar == '.') e.Handled = true;
            if (e.KeyChar == '-' && !txt_pheptinh .Text.Contains("-"))
                txt_pheptinh .Text = "-" + txt_pheptinh .Text;
            if (e.KeyChar == '-' && txt_pheptinh .Text.Contains("-"))
                e.Handled = true;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        

       
        
       
    }
       
}
