﻿using System.Data.Entity;
using CourseManager.Models;

namespace CourseManager.CourseManagerEntities__CourseManager
{
    public class Models_ : DbContext
    {
        // 您可以向此文件中添加自定义代码。更改不会被覆盖。
        // 
        // 如果您希望只要更改模型架构，Entity Framework
        // 就会自动删除并重新生成数据库，则将以下
        // 代码添加到 Global.asax 文件中的 Application_Start 方法。
        // 注意: 这将在每次更改模型时销毁并重新创建数据库。
        // 
        // System.Data.Entity.Database.SetInitializer(new System.Data.Entity.DropCreateDatabaseIfModelChanges<CourseManager.CourseManagerEntities__CourseManager.Models_>());

        public Models_() : base("name=Models_")
        {
        }

        public DbSet<Class> Class { get; set; }
    }
}
