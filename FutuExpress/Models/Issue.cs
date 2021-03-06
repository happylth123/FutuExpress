﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutuExpress.Models
{
    public class Issue
    {
        /// <summary>
        /// IssueId
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Issue Title ID
        /// </summary>
        public string IssueTitle { get; set; }

        /// <summary>
        /// IssueTitleDescription
        /// </summary>
        public string IssueTitleDescription { get; set; }

        /// <summary>
        /// IssueType
        /// </summary>
        public IssueType IssueType { get; set; }

        /// <summary>
        /// Issue Time
        /// </summary>
        public string IssueTime { get; set; }

        /// <summary>
        /// Issue Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Issue State
        /// </summary>
        public IssueStatus Status { get; set; }

        /// <summary>
        /// the log CreateTime
        /// </summary>
        public DateTime? CreateTime { get; set; }

        /// <summary>
        /// the log ModifyTime
        /// </summary>
        public DateTime? ModifyTime { get; set; }

        /// <summary>
        /// Original Estimate
        /// </summary>
        public string OriginalEstimate { get; set; }

        /// <summary>
        /// Issue ReporterId
        /// </summary>
        public string Reporter { get; set; }

        /// <summary>
        /// Issue AssigneeId
        /// </summary>
        public string Assignee { get; set; }

        /// <summary>
        /// IsDeleted
        /// </summary>
        public bool IsDeleted { get; set; }

        /// <summary>
        /// Sprint
        /// </summary>
        public virtual Sprint Sprint { get; set; }

        /// <summary>
        /// IssueLogWork
        /// </summary>
        public virtual ICollection<IssueLogWork> IssueLogWorks { get; set; }
    }
}
