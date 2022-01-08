using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Blockfrost.Api;
using Blockfrost.Api.Extensions;
using Microsoft.Extensions.DependencyInjection;
using Blockfrost.Api.Services;
using CardanoSharp.Wallet;


public class BlockFrostTest : MonoBehaviour
{
    
    /*
    string apiKey = "testnetMh862af5OvnIwtrIDJFa98YG01rQ5TsB";
    string network = "testnet";
    string sender_address = "SENDER_ADDR";
    string receiver_address = "RECEIVER_ADDR";
    string signedTx = File.ReadAllText("path/to/your/signed/transaction");

    string provider = new ServiceCollection().AddBlockfrost(network, apikey).BuildServiceProvider();
    string blockService = provider.GetRequiredService<IBlocksService>();
    string addressService = provider.GetRequiredService<IAddressService>();
    string transactionService = provider.GetRequiredService<ITransactionsService>();

    string utxoSender = await addressService.UtxosAllAsync(sender_address, 100, 0, ESortOrder.Asc).ConfigureAwait(false);
    int totalSender = utxoSender.Sum(m => m.Amount.Sum(a => int.Parse(a.Quantity)));

    Debug.Log(String.Format("Sender Total: {totalSender} lovelace", list.Count));
    //System.Console.WriteLine($"Sender Total: {totalSender} lovelace");

    string utxoReceiver = await addressService.UtxosAllAsync(receiver_address, 100, 0, ESortOrder.Asc).ConfigureAwait(false);
    int totalReceiver = utxoReceiver.Sum(m => m.Amount.Sum(a => int.Parse(a.Quantity)));
    System.Console.WriteLine($"Receiver Total: {totalReceiver} lovelace");

    string tip = await blockService.GetLatestBlockAsync();
    int? slot = tip.Slot;

    Console.WriteLine($"Tip now at Epoch {tip.Epoch} Slot {tip.Slot} Block {tip.Height}");
    Console.WriteLine(signedTx);

    string txid = await transactionService.SubmitAsync(signedTx);

    Console.WriteLine($"Your Transaction was transmitted to the {network}");
    Console.WriteLine($"https://explorer.cardano-{network}.iohkdev.io/en/transaction?id={txid}");
    

    while(slot == tip.Slot)
    {
    Console.WriteLine("Waiting for next block...");
    await Task.Delay(TimeSpan.FromSeconds(3));
    tip = await blockService.GetLatestBlockAsync();
    }

    Console.WriteLine($"Tip now at Epoch {tip.Epoch} Slot {tip.Slot} Block {tip.Height}");
    */
}
