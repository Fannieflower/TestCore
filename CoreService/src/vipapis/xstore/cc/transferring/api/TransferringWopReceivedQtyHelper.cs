using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringWopReceivedQtyHelper : TBeanSerializer<TransferringWopReceivedQty>
	{
		
		public static TransferringWopReceivedQtyHelper OBJ = new TransferringWopReceivedQtyHelper();
		
		public static TransferringWopReceivedQtyHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringWopReceivedQty structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("tx_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTx_id(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("purchase_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPurchase_no(value);
					}
					
					
					
					
					
					if ("received_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetReceived_quantity(value);
					}
					
					
					
					
					
					if ("container_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContainer_no(value);
					}
					
					
					
					
					
					if ("out_purchase_po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOut_purchase_po(value);
					}
					
					
					
					
					
					if ("grade".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetGrade(value);
					}
					
					
					
					
					
					if ("sell_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSell_status(value);
					}
					
					
					
					
					if(needSkip){
						
						ProtocolUtil.skip(iprot);
					}
					
					iprot.ReadFieldEnd();
				}
				
				iprot.ReadStructEnd();
				Validate(structs);
			}
			else{
				
				throw new OspException();
			}
			
			
		}
		
		
		public void Write(TransferringWopReceivedQty structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTx_id() != null) {
				
				oprot.WriteFieldBegin("tx_id");
				oprot.WriteString(structs.GetTx_id());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("tx_id can not be null!");
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			if(structs.GetPurchase_no() != null) {
				
				oprot.WriteFieldBegin("purchase_no");
				oprot.WriteString(structs.GetPurchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("purchase_no can not be null!");
			}
			
			
			if(structs.GetReceived_quantity() != null) {
				
				oprot.WriteFieldBegin("received_quantity");
				oprot.WriteI32((int)structs.GetReceived_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("received_quantity can not be null!");
			}
			
			
			if(structs.GetContainer_no() != null) {
				
				oprot.WriteFieldBegin("container_no");
				oprot.WriteString(structs.GetContainer_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOut_purchase_po() != null) {
				
				oprot.WriteFieldBegin("out_purchase_po");
				oprot.WriteString(structs.GetOut_purchase_po());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetGrade() != null) {
				
				oprot.WriteFieldBegin("grade");
				oprot.WriteString(structs.GetGrade());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSell_status() != null) {
				
				oprot.WriteFieldBegin("sell_status");
				oprot.WriteI32((int)structs.GetSell_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringWopReceivedQty bean){
			
			
		}
		
	}
	
}