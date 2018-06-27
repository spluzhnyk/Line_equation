using Microsoft.VisualStudio.TestTools.UnitTesting;
using Line_equation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Line_equation.Tests
{
    [TestClass()]
    public class Line_eq_formTests
    {
        Line_equation.Line_eq_form g = new Line_equation.Line_eq_form();
        [TestMethod()]
        public void Line_eq_formTest()
        { 
            double
                a = 1,
                b = -1,
                c = 5,
                d = 3,
                e = 2,
                f = 0;
            string x = null, y = null;
            g.SLAU_solve(a, b, c, d, e, f);
            x = Convert.ToString(g.x);
            y = Convert.ToString(g.y);
            Assert.AreEqual(x, "2");
            Assert.AreEqual(y, "-3");
        }

        [TestMethod()]
        public void Line_eq_formTest1()
        {
            double
                a = 1,
                b = -1,
                c = 3,
                d = 3,
                e = 2,
                f = -1;
            string x = null, y = null;
            g.SLAU_solve(a, b, c, d, e, f);
            x = Convert.ToString(g.x);
            y = Convert.ToString(g.y);
            Assert.AreEqual(x, "1");
            Assert.AreEqual(y, "-2");
        }

        [TestMethod()]
        public void Line_eq_formTest2()
        {
            double
                a = 960,
                b = 520,
                c = 43.5,
                d = 65,
                e = 333.6,
                f = 1;
            string x = null, y = null;
            g.SLAU_solve(a, b, c, d, e, f);
            x = Convert.ToString(g.x);
            y = Convert.ToString(g.y);
            Assert.AreEqual(x, "0,0488438014913285");
            Assert.AreEqual(y, "-0,00651932583014494");
        }

    }
}