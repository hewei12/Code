using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public abstract class Player
    {
        protected string name;
        public Player(string name)
        {
            this.name = name;
        }

        public abstract void Attack();
        public abstract void Defense();
    }

    public class Forwards : Player
    {
        public string name;
        public Forwards(string name) : base(name)
        {
            this.name = name;
        }

        public override void Attack()
        {
            Console.WriteLine("");
        }
        public override void Defense()
        {
            Console.WriteLine("");
        }
    }

    public class ForeignCenter
    {
        public string name = "";

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void 进攻()
        {
            Console.WriteLine("");
        }
        public void 防守()
        {
            Console.WriteLine("");
        }
    }

    public class Transloter:Player
    {
        ForeignCenter fc = new ForeignCenter();
        public Transloter(string name):base(name)
        {
            fc.Name = name;
        }
        
        public override void Attack()
        {
            fc.进攻();    
        }

        public override void Defense()
        {
            fc.防守();    
        }

    }
}
