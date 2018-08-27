using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;


/// <summary>
/// Descripción breve de Popular
/// </summary>
public class Popular
{
    public Popular()
    {

    }

    public Popular(int cant)
    {
        this.cantidad = +1;
    }

    private int numero;


    public int Numero
    {
        get { return this.numero; }
        set { this.numero = value; }
    }


    private int cantidad;

    public int Cantidad
    {
        get { return this.cantidad; }
        set { this.cantidad = value; }
    }




    public string ValidarNumero(string nro)
    {

        //Regex rex = new Regex("/^[0-9]+$/");

        // Regex rex = new Regex(@"^[0-9]+([,][0-9]+)?$");



        //if (Regex.IsMatch(nro, "^[0-9]+(,[0-9]+)?$"))
        //    if (Regex.IsMatch(nro, "[\d,]+"))
        //{

        //    return "bien";

        //}
        //else
        //{
        //    return "mal";
        //}


            //if (rex.IsMatch(nro, 0))
            //{

            //    return "bien";

            //}
            //else
            //{
            //    return "mal";

            //}

            //string rgx = (@"^[0-9]+([,][0-9]+)?$");



            //rgx=Regex.Replace(nro, rgx, string.Empty);

            return "ok";
        }
    }

    




