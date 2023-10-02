﻿namespace WeDontNeedPeformanceBench;

public class RAMTests
{
    private List<Dummy> inner = new( );
    
    public async Task Create(int times)
    {
        for (var i = 0; i < times; i++)
        {
            inner.Add(new Dummy());
        }

        await Task.Delay(5);
    }

    private class Dummy
    {
        private const string Inner1KbField = "66125646655438184824034357503490176636099264991633465762201498014519123891859268733983653039388726432642995143358504569007771" + "58598693402496866943402835041634570224118066330404568236483221494076492917098844866249914290879929866424562331479470484929530" + "47981071980750177177087538144356263522627349597567256092672809627220185268573884037546233149941048425721886017397002493771038" + "59789493522946388742872159309483907924798646897590296799087138432035293041592297258616156208443607672462374144231313952523825" + "41214722436789521357506910806784385239131212667915286065697223577192349536631069819291852420161751071280762096700317526464632" + "90928765621229518421461199169418959317189370377096223039048075197848769839858594855143546758093458201630388955491473164903161" + "19029733685356457419092050823362333977133993758927393621966880365414110809808625711116204972494708604941468381375412202718800" + "30757276143464395289644876909915866493212206250053550400385293673376701537468360960764657913786708380781323834871961191069325" + "5294339716425075";

        // private readonly string[] _innerArray = new string[1];

        // public Dummy()
        // {
        //     for (var i = 0; i < 1; i++)
        //     {
        //         _innerArray[i] = new string(Inner1KbField);
        //     }
        // }
    }

}
