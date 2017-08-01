using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DoWithEasy();
            DoWithParameter();
            DoWithTimer();
            DoWithThreadPool();
            DoWithThreadPoolParameter();
            DoWithAnonymous();
            DoWithLambda();
            DoWithCommon();
            DoWithAction();
            DoWithFunc();
            DoWithPredicate();
        }

        #region 创建一个简单线程
        private void DoWithEasy()
        {
            Thread t = new Thread(new ThreadStart(this.DoSomeThingWithEasy));
            t.Start();
        }

        private void DoSomeThingWithEasy()
        {
            MessageBox.Show("kinghts Warrior");
        }
        #endregion

        #region 创建带参数线程
        private void DoWithParameter()
        {
            Thread t = new Thread(new ParameterizedThreadStart(this.DoSomeThingWithParameter));
            t.Start("kinghts Warrior");
        }

        private void DoSomeThingWithParameter(object x)
        {
            MessageBox.Show(x.ToString());
        }
        #endregion

        #region Timer创建线程
        private void DoWithTimer()
        {
            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
            timer.Interval = 1000;//1s
            //委托：delegate void EventHandler(object sender, EventArgs e)
            timer.Tick += (x, y) =>//lambda表达式
              {
                  MessageBox.Show("kingths Warriors");
              };
            timer.Start();
        }
        #endregion

        #region ThreadPool无参线程
        private void DoWithThreadPool()
        {
            //委托：delegate void WaitCallback(object state)
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.DoSomeThingWithThreadPool));
        }

        private void DoSomeThingWithThreadPool(object x)
        {
            MessageBox.Show("kingths Warrior");
        }
        #endregion

        #region ThreadPool有参线程
        private void DoWithThreadPoolParameter()
        {
            //QueueUserWorkItem(WaitCallback x,object state) state:参数
            ThreadPool.QueueUserWorkItem(new WaitCallback(this.DoSomeThingWithThreadPoolParameter), "kinghts Warrior");
        }
        private void DoSomeThingWithThreadPoolParameter(object x)
        {
            MessageBox.Show(x.ToString());
        }
        #endregion

        #region 匿名委托线程
        private void DoWithAnonymous()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(delegate (object x)
            {
                MessageBox.Show("kingths Warrior");
            }));

        }
        #endregion

        #region Lambda创建线程
        private void DoWithLambda()
        {
            ThreadPool.QueueUserWorkItem(new WaitCallback(x =>
            {
                MessageBox.Show("kingths Warrior");
            }));
        }
        #endregion

        #region 自定义委托线程
        private void DoWithCommon()
        {
            WaitCallback waitCallback = new WaitCallback(this.InvokeMethod);
            ThreadPool.QueueUserWorkItem(waitCallback, "kingths Warrior");

        }
        private delegate void InvokeMethodDelegate(string name);
        private void InvokeMethod(object x)
        {
            this.Invoke(new InvokeMethodDelegate(this.ChangeUIWithCommon), x.ToString());
        }

        private void ChangeUIWithCommon(string name)
        {
            this.textBox1.Text = name;
        }
        #endregion

        #region Action委托
        private void DoWithAction()
        {
            WaitCallback waitCallback = new WaitCallback(this.DoSomeThingWithAciton);
            ThreadPool.QueueUserWorkItem(waitCallback, "kingths Warrior");
        }
        //Invoke自带的窗体委托
        private void DoSomeThingWithAciton(object x)
        {
            this.Invoke(new Action<string>(e =>
            {
                this.textBox1.Text = e;
            })
            , x.ToString());
        }
        #endregion

        #region Func委托
        private void DoWithFunc()
        {
            WaitCallback waitCallback = new WaitCallback(this.DoSomeThingWithFunc);
            ThreadPool.QueueUserWorkItem(waitCallback, "kingths Warrior");
        }

        private void DoSomeThingWithFunc(object x)
        {
            //Func<string,int>存在输入和输出 result用来接收返回值输出
            //Func<string>这种写法是错误的，没有输出
            object result = this.Invoke(new Func<string, int>(o =>
               {
                   this.textBox1.Text = o;
                   if (o == "kingths Warrior")
                       return 1;
                   else
                       return 0;
               }), x.ToString());
            MessageBox.Show(result.ToString());
        }
        #endregion

        #region Predicate委托
        private void DoWithPredicate()
        {
            WaitCallback waitCallback = new WaitCallback(this.DoSomeThingPredicate);
            ThreadPool.QueueUserWorkItem(waitCallback, "kingths Warrior");
        }

        private void DoSomeThingPredicate(object x)
        {
            //Predicate委托接收一个T参数，返回true或者false
            object result = this.Invoke(new Predicate<string>(o =>
              {
                  this.textBox1.Text = o;
                  if (o == "kingths Warrior")
                      return true;
                  else
                      return false;
              }), x.ToString());
            MessageBox.Show(result.ToString());
        }
        #endregion
    }
}
