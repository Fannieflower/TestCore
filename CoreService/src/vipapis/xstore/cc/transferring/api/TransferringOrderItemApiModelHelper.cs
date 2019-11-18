using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringOrderItemApiModelHelper : TBeanSerializer<TransferringOrderItemApiModel>
	{
		
		public static TransferringOrderItemApiModelHelper OBJ = new TransferringOrderItemApiModelHelper();
		
		public static TransferringOrderItemApiModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringOrderItemApiModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("transferring_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransferring_order_no(value);
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
					
					
					
					
					
					if ("transferring_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTransferring_quantity(value);
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
		
		
		public void Write(TransferringOrderItemApiModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTransferring_order_no() != null) {
				
				oprot.WriteFieldBegin("transferring_order_no");
				oprot.WriteString(structs.GetTransferring_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPurchase_no() != null) {
				
				oprot.WriteFieldBegin("purchase_no");
				oprot.WriteString(structs.GetPurchase_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransferring_quantity() != null) {
				
				oprot.WriteFieldBegin("transferring_quantity");
				oprot.WriteI32((int)structs.GetTransferring_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringOrderItemApiModel bean){
			
			
		}
		
	}
	
}