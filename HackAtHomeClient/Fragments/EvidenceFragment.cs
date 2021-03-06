﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using HackAtHome.Entities;

namespace HackAtHomeClient.Fragments
{
    public class EvidenceFragment : Fragment
    {
        public string FullName { get; set; }

        public string Token { get; set; }

        public List<Evidence> EvidenceList { get; set; }

        public IParcelable EvidenceListState { get; set; }

        public override string ToString()
        {
            return $"{FullName} - {Token}";
        }

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            RetainInstance = true;
        }
    }
}