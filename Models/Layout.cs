
namespace Models
{
    public class Layout : Base.Entity
    {
        public Layout() : base()
        {
        }

        // **********
        /// <summary>
        /// /عنوان Layout
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Name))]

        public string Name { get; set; }
        // **********

        // **********
        /// <summary>
        /// متن Layout
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Content))]

        public string Content { get; set; }
        // **********

        // **********
        /// <summary>
        /// جهت ایجاد ارتباط یک به چند بین Layout وPage
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Page))]
       
        public System.Collections.Generic.IList<Page> Pages { get; set; }
        // **********

        // **********
        /// <summary>
        /// تاریخ بروز رسانی
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.UpdateTime))]

        public DateTime UpdateTime { get; set; }
        // **********

        // **********
        /// <summary>
        /// جهت ایجاد ارتباط یک به چند بین Layout , Post
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Post))]

        public System.Collections.Generic.IList<Post> Posts { get; set; }
        // **********

        // **********
        /// <summary>
        /// زبان
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Culture))]

        public string Culture { get; set; }
        // **********

        // **********
        /// <summary>
        /// توضیحات
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Description))]

        public string Description { get; set; }
        // **********

        // **********
        /// <summary>
        /// راست به چپ بودن Layout
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.IsRtl))]

        public bool IsRtl { get; set; }
        // **********

        // **********
        /// <summary>
        /// تاریخ ایجاد
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.CreateDate))]

        public DateTime CreateDate { get; set; }
        // **********

        // **********
        /// <summary>
        /// ایجاد کننده
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.Creator))]

        public string Creator { get; set; }
        // **********

        // **********
        /// <summary>
        /// فعال بودن Layout
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.IsActive))]

        public bool IsActive { get; set; }
        // **********

        // **********
        /// <summary>
        /// پیش فرض بودن یا نبودن Layout
        /// </summary>
        [System.ComponentModel.DataAnnotations.Display
            (ResourceType = typeof(Resources.DataDictionary),
            Name = nameof(Resources.DataDictionary.IsDefault))]

        public bool IsDefault { get; set; }
    }
}
