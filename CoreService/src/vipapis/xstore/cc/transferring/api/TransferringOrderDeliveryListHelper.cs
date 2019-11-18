using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.xstore.cc.transferring.api{
	
	
	
	public class TransferringOrderDeliveryListHelper : TBeanSerializer<TransferringOrderDeliveryList>
	{
		
		public static TransferringOrderDeliveryListHelper OBJ = new TransferringOrderDeliveryListHelper();
		
		public static TransferringOrderDeliveryListHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(TransferringOrderDeliveryList structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("company_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCompany_code(value);
					}
					
					
					
					
					
					if ("transferring_order_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTransferring_order_no(value);
					}
					
					
					
					
					
					if ("delivery_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDelivery_warehouse_code(value);
					}
					
					
					
					
					
					if ("delivery_date".Equals(schemeField.Trim())){
						
						needSkip = false;
						System.DateTime? value;
						value = Osp.Sdk.Util.TimeUtil.FromUnixTime(iprot.ReadI64()); 
						
						structs.SetDelivery_date(value);
					}
					
					
					
					
					
					if ("transferring_type".Equals(schemeField.Trim())){
						
						needSkip = false;
						byte? value;
						value = iprot.ReadByte(); 
						
						structs.SetTransferring_type(value);
					}
					
					
					
					
					
					if ("src_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSrc_warehouse_code(value);
					}
					
					
					
					
					
					if ("dest_warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDest_warehouse_code(value);
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
		
		
		public void Write(TransferringOrderDeliveryList structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCompany_code() != null) {
				
				oprot.WriteFieldBegin("company_code");
				oprot.WriteString(structs.GetCompany_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransferring_order_no() != null) {
				
				oprot.WriteFieldBegin("transferring_order_no");
				oprot.WriteString(structs.GetTransferring_order_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelivery_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("delivery_warehouse_code");
				oprot.WriteString(structs.GetDelivery_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDelivery_date() != null) {
				
				oprot.WriteFieldBegin("delivery_date");
				oprot.WriteI64(Osp.Sdk.Util.TimeUtil.ToUnixTime((System.DateTime)structs.GetDelivery_date())); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTransferring_type() != null) {
				
				oprot.WriteFieldBegin("transferring_type");
				oprot.WriteByte((byte)structs.GetTransferring_type()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSrc_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("src_warehouse_code");
				oprot.WriteString(structs.GetSrc_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDest_warehouse_code() != null) {
				
				oprot.WriteFieldBegin("dest_warehouse_code");
				oprot.WriteString(structs.GetDest_warehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(TransferringOrderDeliveryList bean){
			
			
		}
		
	}
	
}