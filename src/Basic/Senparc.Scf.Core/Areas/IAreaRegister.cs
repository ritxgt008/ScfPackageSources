﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Senparc.Scf.Core.Areas
{
    /// <summary>
    /// Area 的 Register 接口
    /// </summary>
    public interface IAreaRegister
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="env"></param>
        /// <returns></returns>
        IMvcBuilder AuthorizeConfig(IMvcBuilder builder, IWebHostEnvironment env);

        /// <summary>
        /// 如果提供了 UI 界面，必须指定一个首页，如：Admin/
        /// <para>注意：此选项需要配合 XscfRegister 使用才有效，否则请忽略</para>
        /// </summary>
        string HomeUrl { get; }

        /// <summary>
        /// 菜单项
        /// </summary>
        List<AreaPageMenuItem> AareaPageMenuItems { get; }
    }
}
