using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringDeliveryItemHelper : TBeanSerializer<TransferringDeliveryItem>
	{
		
		public static TransferringDeliveryItemHelper OBJ = new TransferringDeliveryItemHelper();
		
		public static TransferringDeliveryItemHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringDeliveryItem structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
					}
					
					
					
					
					
					if ("delivery_quantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetDelivery_quantity(value);
					}
					
					
					
					
					
					if ("container_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContainer_no(value);
					}
					
					
					
					
					
					if ("tx_id".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTx_id(value);
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
		
		
		public void Write(TransferringDeliveryItem structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			if(structs.GetDelivery_quantity() != null) {
				
				oprot.WriteFieldBegin("delivery_quantity");
				oprot.WriteI32((int)structs.GetDelivery_quantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContainer_no() != null) {
				
				oprot.WriteFieldBegin("container_no");
				oprot.WriteString(structs.GetContainer_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTx_id() != null) {
				
				oprot.WriteFieldBegin("tx_id");
				oprot.WriteString(structs.GetTx_id());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringDeliveryItem bean){
			
			
		}
		
	}
	
}