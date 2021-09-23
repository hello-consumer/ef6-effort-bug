using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    public class MyDB : DbContext
    {
        public MyDB(string nameOrConnectionString) : base(nameOrConnectionString)
        {
        }

        public MyDB(string nameOrConnectionString, DbCompiledModel model) : base(nameOrConnectionString, model)
        {
        }

        public MyDB(DbConnection existingConnection, bool contextOwnsConnection) : base(existingConnection, contextOwnsConnection)
        {
        }

        public MyDB(ObjectContext objectContext, bool dbContextOwnsObjectContext) : base(objectContext, dbContextOwnsObjectContext)
        {
        }

        public MyDB(DbConnection existingConnection, DbCompiledModel model, bool contextOwnsConnection) : base(existingConnection, model, contextOwnsConnection)
        {
        }

        protected MyDB()
        {
        }

        protected MyDB(DbCompiledModel model) : base(model)
        {
        }

        public virtual DbSet<Foo> Foos { get; set; }

        public virtual DbSet<Bar> Bars { get; set; }

        public virtual DbSet<Baz> Bazs { get; set; }

        public virtual DbSet<Qux> Quxii { get; set; }

        public virtual DbSet<Quux> Quuxii { get; set; }

        public virtual DbSet<Corge> Corges { get; set; }

        public virtual DbSet<Grault> Graults { get; set; }

        public virtual DbSet<Garply> Garplies { get; set; }

        public virtual DbSet<Waldo> Waldos { get; set; }

        public virtual DbSet<Fred> Freds { get; set; }

        public virtual DbSet<Plugh> Plughs { get; set; }

        public virtual DbSet<Xyzzy> Xyzzies { get; set; }

        public virtual DbSet<Thud> Thuds { get; set; }
    }

    
    public class Foo
    {
        public Guid ID { get; set; }
    }
    public class Bar
    {
        public Guid ID { get; set; }
    }

    public class Baz
    {
        public Guid ID { get; set; }
    }

    public class Qux
    {
        public Guid ID { get; set; }
    }
    public class Quux
    {
        public Guid ID { get; set; }
    }

    public class Corge
    {
        public Guid ID { get; set; }
    }

    public class Grault
    {
        public Guid ID { get; set; }
    }


    public class Garply
    {
        public Guid ID { get; set; }
    }

    public class Waldo
    {
        public Guid ID { get; set; }
    }

    public class Fred
    {
        public Guid ID { get; set; }
    }

    public class Plugh
    {
        public Guid ID { get; set; }
    }

    public class Xyzzy
    {
        public Guid ID { get; set; }
    }

    public class Thud
    {
        public Guid ID { get; set; }
    }

}
