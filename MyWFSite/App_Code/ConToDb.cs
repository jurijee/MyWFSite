﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;


/// <summary>
/// Returns connection string from WebConfig based on provided connection name
/// </summary>
public class ConToDb
{
    private string connName;

    public ConToDb(string connName)
    {
        this.connName = connName;
    }

    public string GetConnectionString() {
        return ConfigurationManager.ConnectionStrings[connName].ConnectionString;
    }
}