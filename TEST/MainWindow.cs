using System;
using Gtk;

using System.Text;
using System.Data;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

using System.IO;
using System.IO.Ports;
using System.Threading;
using System.Drawing;
using System.Linq;




public partial class MainWindow : Gtk.Window
{
    public SerialPort spp = new SerialPort();
    public IList<string> ComList = new List<string>();

    #region Init
    private void SerialPortSerch()
    {
        int i = 0;
        // Serial Port Serch
        string[] splist = SerialPort.GetPortNames();
        ComList.Clear();
        i = combobox1.RowSpanColumn;

        foreach (string pd in splist)
        {
            ComList.Add(pd);
            string bbb = pd.Substring(4);
            combobox1.AppendText(bbb);
        }

    }



    private void ItemInit()
    {
        SerialPortSerch();
    }
    #endregion



    public MainWindow() : base(Gtk.WindowType.Toplevel)
    {
        Build();
        ItemInit();
    }


    protected void OnDeleteEvent(object sender, DeleteEventArgs a)
    {
        Application.Quit();
        a.RetVal = true;
    }

    protected void OnButton1Clicked(object sender, EventArgs e)
    {
        int hoge = combobox1.Data.Count;
        for (int i=0; i<10; i++)
        {
        }
    }
}
