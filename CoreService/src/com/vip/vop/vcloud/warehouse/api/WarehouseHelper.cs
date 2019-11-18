using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.warehouse.api{
	
	
	
	public class WarehouseHelper : TBeanSerializer<Warehouse>
	{
		
		public static WarehouseHelper OBJ = new WarehouseHelper();
		
		public static WarehouseHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Warehouse structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("partnerId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetPartnerId(value);
					}
					
					
					
					
					
					if ("warehouseCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouseCode(value);
					}
					
					
					
					
					
					if ("warehouseName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouseName(value);
					}
					
					
					
					
					
					if ("safeQuantity".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSafeQuantity(value);
					}
					
					
					
					
					
					if ("address".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.vcloud.warehouse.api.Address value;
						
						value = new com.vip.vop.vcloud.warehouse.api.Address();
						com.vip.vop.vcloud.warehouse.api.AddressHelper.getInstance().Read(value, iprot);
						
						structs.SetAddress(value);
					}
					
					
					
					
					
					if ("isVirtual".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetIsVirtual(value);
					}
					
					
					
					
					
					if ("description".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetDescription(value);
					}
					
					
					
					
					
					if ("vipStoreSn".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipStoreSn(value);
					}
					
					
					
					
					
					if ("receiverMobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverMobile(value);
					}
					
					
					
					
					
					if ("receiverName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetReceiverName(value);
					}
					
					
					
					
					
					if ("senderMobile".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderMobile(value);
					}
					
					
					
					
					
					if ("senderName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSenderName(value);
					}
					
					
					
					
					
					if ("priority".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetPriority(value);
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
		
		
		public void Write(Warehouse structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPartnerId() != null) {
				
				oprot.WriteFieldBegin("partnerId");
				oprot.WriteI64((long)structs.GetPartnerId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouseCode() != null) {
				
				oprot.WriteFieldBegin("warehouseCode");
				oprot.WriteString(structs.GetWarehouseCode());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetWarehouseName() != null) {
				
				oprot.WriteFieldBegin("warehouseName");
				oprot.WriteString(structs.GetWarehouseName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSafeQuantity() != null) {
				
				oprot.WriteFieldBegin("safeQuantity");
				oprot.WriteI32((int)structs.GetSafeQuantity()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAddress() != null) {
				
				oprot.WriteFieldBegin("address");
				
				com.vip.vop.vcloud.warehouse.api.AddressHelper.getInstance().Write(structs.GetAddress(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetIsVirtual() != null) {
				
				oprot.WriteFieldBegin("isVirtual");
				oprot.WriteI32((int)structs.GetIsVirtual()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetDescription() != null) {
				
				oprot.WriteFieldBegin("description");
				oprot.WriteString(structs.GetDescription());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipStoreSn() != null) {
				
				oprot.WriteFieldBegin("vipStoreSn");
				oprot.WriteString(structs.GetVipStoreSn());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverMobile() != null) {
				
				oprot.WriteFieldBegin("receiverMobile");
				oprot.WriteString(structs.GetReceiverMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReceiverName() != null) {
				
				oprot.WriteFieldBegin("receiverName");
				oprot.WriteString(structs.GetReceiverName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderMobile() != null) {
				
				oprot.WriteFieldBegin("senderMobile");
				oprot.WriteString(structs.GetSenderMobile());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSenderName() != null) {
				
				oprot.WriteFieldBegin("senderName");
				oprot.WriteString(structs.GetSenderName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPriority() != null) {
				
				oprot.WriteFieldBegin("priority");
				oprot.WriteI32((int)structs.GetPriority()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Warehouse bean){
			
			
		}
		
	}
	
}