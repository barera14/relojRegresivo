 public List<TipInmueble> GetTipInmueble()
        {
            List<TipInmueble> Lista = new List<TipInmueble>();
            string cadena = ConfigurationManager.ConnectionStrings["conn"].ToString();
            SqlConnection conn = new SqlConnection(cadena);
            StringBuilder sbTabl = new StringBuilder();
            sbTabl.AppendFormat("Exec carTipDocumento {0}", 2);
            using (IDbConnection db = conn)
            {

                Lista = conn.Query<TipInmueble>(sbTabl.ToString()).ToList();
            }
            if (Lista.Count > 0)
                return Lista;
            else
                return null;
        }
        
        
        
        ---controller
        
        
        
          [HttpPost]
        public ActionResult GetTipOferta()
        {
            try
            {
                List<TipOferta> Return = new CapaDatos.Tareas().GetTipOferta();
                if (Return != null)
                {
                    return Json(new { Result = "OK", Records = Return });
                }
                else
                {
                    return Json(new
                    {
                        Result = "ERROR",
                        Message = "No existe datos para tipo documento"
                    });
                }
            }
            catch (Exception ex)
            {
                return Json(new
                {
                    Result = "ERROR",
                    Message = "Ocurrió un error intentando consultar las arl"
                });
            }
        }
        
        
        --- entity
           [Table("TipInmueble")]
        public partial class TipInmueble
        {
            [Key]
            public int idTipInmueble { get; set; }
            public string Nombre { get; set; }
            public string Descripcion { get; set; }
            public string Estado { get; set; }

        }
