using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject.Test
{
    public class AccountControllerPasswordTest
    {
        [
         Test,
         TestCase("abcd", false),
         TestCase("APPLE", false),
         TestCase("cherry", false),
         TestCase("Pear85", false),
         TestCase("CoachPotato11", true)
        ]
        void TestPassword()
        {

        }

    }
}
