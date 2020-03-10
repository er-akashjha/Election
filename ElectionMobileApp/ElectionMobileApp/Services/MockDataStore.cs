using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ElectionMobileApp.Models;

namespace ElectionMobileApp.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        Type d1 = typeof(List<>);

        List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>();
            var mockItems = new List<Item>
            {
                new Item { Id = 1, Text = "First item", Description="This is an item description." },
                new Item { Id = 1, Text = "Second item", Description="This is an item description." },
                new Item { Id = 1, Text = "Third item", Description="This is an item description." },
                new Item { Id = 1, Text = "Fourth item", Description="This is an item description." },
                new Item { Id = 1, Text = "Fifth item", Description="This is an item description." },
                new Item { Id = 1, Text = "Sixth item", Description="This is an item description." }
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }
        public MockDataStore(string TableName)
        {
            if (TableName.Equals("Items"))
            {
                Type[] typeArgs = { typeof(Item) };
                Type makeMe = d1.MakeGenericType(typeArgs);
                object o = Activator.CreateInstance(makeMe);
                items = new List<Item>();
                var mockItems = new List<Item>
                {
                new Item { Id = 1, Text = "First item", Description="This is an item description." },
                new Item { Id = 1, Text = "Second item", Description="This is an item description." },
                new Item { Id = 1, Text = "Third item", Description="This is an item description." },
                new Item { Id = 1, Text = "Fourth item", Description="This is an item description." },
                new Item { Id = 1, Text = "Fifth item", Description="This is an item description." },
                new Item { Id = 1, Text = "Sixth item", Description="This is an item description." }
                };

                foreach (var item in mockItems)
                {
                    items.Add(item);
                }
            }
        }
        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(int id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(int id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }

        

    }
}