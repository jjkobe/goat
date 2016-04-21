using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

/// <summary>
/// PublicUtil 的摘要说明
/// </summary>
public class PublicUtil
{
    public PublicUtil()
    {
        //
        // TODO: 在此处添加构造函数逻辑
        //
    }
    public string GetMD5(string strPwd)
    {
        string cl = DateTime.Now.Month + strPwd + DateTime.Now.Day;
        string pwd = "";
        MD5 md5 = MD5.Create();
        byte[] s = md5.ComputeHash(Encoding.UTF8.GetBytes(cl));
        s.Reverse();
        for (int i = 3; i < s.Length - 1; i++)
        {
            pwd = pwd + (s[i] < 198 ? s[i] + 28 : s[i]).ToString("X");
        }
        return pwd;
    }
}