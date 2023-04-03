using System.Collections.Generic;
using AutoFixture;

namespace WpfApp1
{
    public class MainViewModel
    {
        private readonly Fixture _fixture;

        public MainViewModel()
        {
            _fixture = new Fixture();
        }

        public List<Item> Items => _fixture.Create<List<Item>>();
    }
}
