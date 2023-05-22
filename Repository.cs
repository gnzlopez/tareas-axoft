using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace axoftTareas
{
    public class Repository
    {
        private DBConnection conn;
        public bool isConnect = false;

        public Repository(string strConn = "")
        {
            conn = new DBConnection();
        }

        public void SetStringCon(string strConn)
        {
            conn.ConnectionString = strConn;
            isConnect = conn.ConnectOK();
        }

        public List<Task> GetAll()
        {
            string query = "select * from Tasks";

            return conn.Get(query);
        }

        public List<Task> GetActive()
        {
            string query = $"select * from Tasks where State = {(int)State.Activo}";

            return conn.Get(query);
        }

        public Task GetById(int taskId)
        {
            string query = $"select * from Tasks where IdTask = {taskId}";

            var result = conn.Get(query);

            if (result.Count != 1)
            {
                throw new Exception("Ocurrio un error a buscar la tarea seleccionada");
            }

            return result[0];
        }

        public List<Task> GetByState(int state)
        {
            string query = $"select * from Tasks where State = {state}";

            return conn.Get(query);
        }

        public void Add(Task task)
        {
            var date = task.Date.HasValue ? $"'{task.Date.Value.ToShortDateString()}'" : "null";
            string query = $"insert into Tasks (Name, State, Date) values ('{task.Name}', {(int)task.State}, {date})";

            conn.Set(query);
        }

        public void Update(Task task)
        {

            string date;
            var oldTask = this.GetById(task.Id);

            if (oldTask.Name == task.Name && oldTask.Date == task.Date && oldTask.State == task.State)
            {
                return;
            }

            if(oldTask.State == State.Activo && task.State == State.Diferida)
            {
                date = "null";
            }
            else
            {
                date = task.Date.HasValue ? $"'{task.Date.Value.ToShortDateString()}'" : "null";
            }

            string query = $"update Tasks set Name = '{task.Name}', State = {(int)task.State}, Date = {date} where IdTask = {task.Id}";

            conn.Set(query);
        }

        public void Delete(int taskId)
        {
            string query = $"delete from Tasks where IdTask = {taskId}";

            conn.Set(query);
        }

        public void Complete(int taskId)
        {
            string query = $"update Tasks set State = {(int)State.Completada} where IdTask = {taskId}";

            conn.Set(query);
        }
    }
}
