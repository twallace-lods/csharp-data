using System;
using System.Threading.Tasks;
using System.Collections.Generic;


namespace labfiles
{
    public class MySqlCode
    {
        public async Task<MySqlConnection> getConnection(string host, string port, string database, string user, string password)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }
        public async Task<int> insertOrder(MySqlConnection connection, Order newOrder)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async Task<int> insertOrderDetails(MySqlConnection connection, List<OrderDetail> details)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }

        public async Task exportCustomerOrders(MySqlConnection connection, string dataPath)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();

        }

        public async Task saveCustomerOrdersDocument(MySqlConnection connection, int customerNumber, string dataPath)
        {
            await Task.CompletedTask;
            throw new NotImplementedException();
        }


        //Class end
    }

}