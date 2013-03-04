using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DobrisaCesaric.DomainModel
{
    public class Enums
    {
        public enum VrstaKnjige
        {
            enciklopedija,
            udžbenik,
            rječnik,
            album,
            knjigazamlade,
            književnost,
            publicistika
        }

        public enum ZanrKnjige
        {
            fantastika,
            znanstvenafantastika,
            triler,
            povijest,
            filozofija,
            ekonomija,
            medicina,
            glazba,
            psihologija,
            pravo,
            računarstvo,
            ostalo
        }

        public enum GradjaKnjige
        {
            elektronička,
            tvrdekorice,
            mekekorice
        }
    }
}
