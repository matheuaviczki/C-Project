using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetStorm
{
    class GetText
    {

        public static double MAXLENGTH = 140f; // Tamanho máxmo do Tweet é de 140, então váriavel estatica para limtiar o tamanho

        /// <summary>
        ///     Função criada para retornar uma string de um arquivo lido
        /// </summary>
        /// <returns></returns>
        public static string GetFileText()
        {
            var filestream = new FileStream(@"c:\texto.txt", FileMode.Open, FileAccess.Read); // Abre e le o arquivo(path, modo, tipo de acesso)
            string text = "";

            try
            {
                var streamread = new StreamReader(filestream, Encoding.ASCII); // StreamReader para leitura do arquivo

                text = streamread.ReadToEnd(); // Lendo e armazenando em uma string
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                filestream.Close(); // Fechando o arquivo
            }

            return text;
        }

        
    }
}
