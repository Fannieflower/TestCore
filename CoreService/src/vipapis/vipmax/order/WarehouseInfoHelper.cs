using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.vipmax.order{
	
	
	
	public class WarehouseInfoHelper : TBeanSerializer<WarehouseInfo>
	{
		
		public static WarehouseInfoHelper OBJ = new WarehouseInfoHelper();
		
		public static WarehouseInfoHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(WarehouseInfo structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("warehouse".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse(value);
					}
					
					
					
					
					
					if ("warehouse_name".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse_name(value);
					}
					
					
					
					
					
					if ("warehouse_address".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse_address(value);
					}
					
					
					
					
					
					if ("warehouse_tel".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse_tel(value);
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
		
		
		public void Write(WarehouseInfo structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetWarehouse() != null) {
				
				oprot.WriteFieldBegin("warehouse");
				oprot.WriteString(structs.GetWarehouse());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse can not be null!");
			}
			
			
			if(structs.GetWarehouse_name() != null) {
				
				oprot.WriteFieldBegin("warehouse_name");
				oprot.WriteString(structs.GetWarehouse_name());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse_name can not be null!");
			}
			
			
			if(structs.GetWarehouse_address() != null) {
				
				oprot.WriteFieldBegin("warehouse_address");
				oprot.WriteString(structs.GetWarehouse_address());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse_address can not be null!");
			}
			
			
			if(structs.GetWarehouse_tel() != null) {
				
				oprot.WriteFieldBegin("warehouse_tel");
				oprot.WriteString(structs.GetWarehouse_tel());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(WarehouseInfo bean){
			
			
		}
		
	}
	
}