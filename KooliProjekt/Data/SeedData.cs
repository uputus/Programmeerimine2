namespace KooliProjekt.Data
{
   
    
        public static class SeedData
        {
            public static void Generate(ApplicationDbContext context)
            {
                if (context.TodoLists.Any())
                {
                    return;
                }

                var list = new TodoList();
                list.Title = "List 1";
                list.Items.Add(new TodoItem
                {
                    Title = "Item 1.1"
                });

                context.TodoLists.Add(list);

                // Veel andmeid

                context.SaveChanges();
            }
        }
    
}