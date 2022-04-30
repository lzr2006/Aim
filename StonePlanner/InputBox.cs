using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StonePlanner
{
    #region DEFINE
    public unsafe class InputBoxDefine
    {
        public const int MAX_LENGTH_OF_LPCAPTION = 128;
        public const int MAX_LENGTH_OF_LPTEXT = 512;
        public const int MAX_LENGTH_OF_SZVALUEBACK = 256;
    }
    #endregion
    public unsafe struct InputBoxStruct
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = InputBoxDefine.MAX_LENGTH_OF_LPCAPTION)]
        internal string lpCaption;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = InputBoxDefine.MAX_LENGTH_OF_LPTEXT)]
        internal string lpText;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = InputBoxDefine.MAX_LENGTH_OF_SZVALUEBACK)]
        internal char* szValueBack;
    }
    public unsafe partial class InputBox : Form
    {
        string lpCaption;
        string lpText;
        internal bool IN = false;
        char[] szFileNameSize = new char[256];
        internal char* szValueBack;
        //使用类全局变量作为控制
        internal InputBox(InputBoxStruct IBS)
        {
            InitializeComponent();
            this.lpCaption = IBS.lpCaption;
            this.lpText = IBS.lpText;
            this.szValueBack = IBS.szValueBack; //关联指针
        }
        private void InputBox_Load(object sender, EventArgs e)
        {
            this.textBox1.Text = lpText;
            this.Text = lpCaption;
            ////封送对象至非托管内存块
            //InputBoxStruct mainIBS = new InputBoxStruct();
            //IntPtr intPtr = Marshal.AllocHGlobal(Marshal.SizeOf(mainIBS));
            //try
            //{
            //    //将数据从托管对象封送到非托管内存块,该内存块开始地址为**intPtr**
            //    Marshal.StructureToPtr(mainIBS, intPtr, false);

            //    //将数据从非托管内存块封送到新分配的指定类型的托管对象
            //    InputBoxStruct anotherPerson = (InputBoxStruct)Marshal.PtrToStructure(intPtr, typeof(InputBoxStruct));
            //}
            //catch (ArgumentException)
            //{
            //    throw;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] szFileNameSize = new char[256];
            //在这里szValueBack指向的地址被修改

            char* temp = szValueBack;
            //提取字符串中每一个字符
            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                *temp++ = (char)textBox1.Text[i];
            }
            IN = !IN;
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            char back = '0';
            szValueBack = &back;
            IN = !IN;
            Close();
        }

        //foreach (char item in textBox1.Text)
        //{
        //    szValueBack[i] = &item;
        //    i++;
        //}
    }
}
