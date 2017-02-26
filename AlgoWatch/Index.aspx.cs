using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AlgoWatch
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetMethods_Click(object sender, EventArgs e)
        {
            Assembly myLibrary = Assembly.LoadFile(txtDll.Text);

            // get type of class loaded assembly
            Type clsType = myLibrary.GetType("AlgorithmsDataStructures.Sorting");

            MethodInfo[] methods = clsType.GetMethods();
            Label1.Text = "";
            foreach (var item in methods)
            {
                Label1.Text += String.Format("{0}<br />", item.Name);
            }

        }

        protected void btnCall_Click(object sender, EventArgs e)
        {
            string[] a_temp = txtInput.Text.Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);


            Assembly myLibrary = Assembly.LoadFile(txtDll.Text);

            // get type of class loaded assembly
            Type clsType = myLibrary.GetType("AlgorithmsDataStructures.Sorting");

            MethodInfo[] methods = clsType.GetMethods();

            if (methods != null)
            {
                var watch = System.Diagnostics.Stopwatch.StartNew();//TimeComplexity

                methods.First(s => s.Name == txtMethod.Text.Trim())
                .Invoke(null, new object[] { a });

                var elapsedMs = watch.ElapsedMilliseconds;
                Label2.Text = "Time: " + elapsedMs.ToString() + " ms, Total Memory: " + (GC.GetTotalMemory(false) / 1024).ToString() + " MB";

            }
            else
            {
                Label1.Text = "Please methods first";
            }


        }


    }
}