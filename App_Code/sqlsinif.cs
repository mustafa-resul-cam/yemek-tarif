﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

public class sqlsinif
{
    public SqlConnection baglanti()
    {
        SqlConnection baglan = new SqlConnection(@"Data Source=LAPTOP-V5VNCCGE;Initial Catalog=Dbo_yemektarifi;Integrated Security=True");
        baglan.Open();
        return baglan;
    }
}