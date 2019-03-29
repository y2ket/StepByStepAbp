﻿using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace BeiDream.SbsAbp.Demo.DemoTasks.Dto
{
    public class DemoTaskListDto : EntityDto<Guid>, IHasCreationTime
    {
        /// <summary>
        /// 任务名称
        /// </summary>

        public string Name { get; set; }
        /// <summary>
        /// 任务数量
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 是否发布
        /// </summary>
        public bool IsPublish { get; set; }
        /// <summary>
        /// 发布时间
        /// </summary>
        public DateTime? PublishTime { get; set; }
        public DateTime CreationTime { get ; set; }
    }
}
