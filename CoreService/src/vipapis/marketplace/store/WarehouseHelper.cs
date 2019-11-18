using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace vipapis.marketplace.store{
	
	
	
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
					
					
					if ("warehouse_code".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetWarehouse_code(value);
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
					
					
					
					
					
					if ("active_status".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActive_status(value);
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
			
			if(structs.GetWarehouse_code() != null) {
				
				oprot.WriteFieldBegin("warehouse_code");
				oprot.WriteString(structs.GetWarehouse_code());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("warehouse_code can not be null!");
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
			
			
			if(structs.GetActive_status() != null) {
				
				oprot.WriteFieldBegin("active_status");
				oprot.WriteI32((int)structs.GetActive_status()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("active_status can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Warehouse bean){
			
			
		}
		
	}
	
}