﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace group12_FinalProject1
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEasy_Click(object sender, EventArgs e)
        {
            String prob20Title;
            prob20Title = "Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.\r\n\r\nAn input string is valid if:\r\n\r\nOpen brackets must be closed by the same type of brackets.\r\nOpen brackets must be closed in the correct order.\r\nEvery close bracket has a corresponding open bracket of the same type. Test Case: ()";
            lblProblemTitle.Text = prob20Title;
            LeetCodeProblem20 mySolution = new LeetCodeProblem20();
            String validParenthsis;
            validParenthsis = mySolution.IsValid("()").ToString();
            lblSolutionDescription.Text = validParenthsis;

        }

        protected void btnMedium_Click(object sender, EventArgs e)
        {
            String prob371Title;
            prob371Title = " Given two integers a and b, return the sum of the two integers without using the operators + and.Test Code: a=1 b=2";
            lblProblemTitle.Text = prob371Title;
            LeetCodeProblem371 mySolution = new LeetCodeProblem371();
            String sumofTwoInt;
            sumofTwoInt = mySolution.GetSum(1, 2).ToString();
            lblSolutionDescription.Text = sumofTwoInt;
        }

        protected void btdHard_Click(object sender, EventArgs e)
        {
            String prob10Title;
            prob10Title = "Given an input string s and a pattern p, implement regular expression matching with support for '.' and '*' where: '.' Matches any single character and '*' Matches zero or more of the preceding element. The matching should cover the entire input string (not partial). Test Case: s = aa p = a";
            lblProblemTitle.Text = prob10Title;
            LeetCodeProblem_10 mySolution = new LeetCodeProblem_10();
            String expressionMatch;
            expressionMatch = mySolution.IsMatch("aa", "a").ToString();
            lblSolutionDescription.Text = expressionMatch;
        }
    }
}