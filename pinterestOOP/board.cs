using System;
using System.Collections.Generic;

namespace pinterestOOP
{
    public class Board
    {
        private string namaBoard;
        private List<Content> koleksiPin = new List<Content>();

        public string NamaBoard
        {
            get { return this.namaBoard; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Peringatan: Nama board kosong, diganti menjadi Papan Tanpa Nama.");
                    this.namaBoard = "Papan Tanpa Nama";
                }
                else
                {
                    this.namaBoard = value;
                }
            }
        }

        public Board(string nama)
        {
            this.NamaBoard = nama;
        }

        public void TambahPinKeBoard(Content pinBaru)
        {
            this.koleksiPin.Add(pinBaru);
            Console.WriteLine($"Pin {pinBaru.Id} ditambahkan ke papan {this.NamaBoard}");
        }
    }
}