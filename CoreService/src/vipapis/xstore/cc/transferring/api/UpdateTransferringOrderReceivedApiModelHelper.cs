using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class UpdateTransferringOrderReceivedApiModelHelper : TBeanSerializer<UpdateTransferringOrderReceivedApiModel>
	{
		
		public static UpdateTransferringOrderReceivedApiModelHelper OBJ = new UpdateTransferringOrderReceivedApiModelHelper();
		
		public static UpdateTransferringOrderReceivedApiModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdateTransferringOrderReceivedApiModel structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("out_purchase_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOut_purchase_no(value);
					}
					
					
					
					
					
					if ("received_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceived_quantity(value);
					}
					
					
					
					
					
					if ("container_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContainer_no(value);
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
		
		
		public void Write(UpdateTransferringOrderReceivedApiModel structs, Protocol oprot){
			
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
			
			
			if(structs.GetOut_purchase_no() != null) {
				
				oprot.WriteFieldBegin("out_purchase_no");
				oprot.WriteString(structs.GetOut_purchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceived_quantity() != null) {
				
				oprot.WriteFieldBegin("received_quantity");
				oprot.WriteString(structs.GetReceived_quantity());
				
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
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(UpdateTransferringOrderReceivedApiModel bean){
			
			
		}
		
	}
	
}