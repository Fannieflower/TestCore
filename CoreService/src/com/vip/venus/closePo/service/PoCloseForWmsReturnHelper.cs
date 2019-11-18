using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.venus.closePo.service{
	
	
	
	public class PoCloseForWmsReturnHelper : TBeanSerializer<PoCloseForWmsReturn>
	{
		
		public static PoCloseForWmsReturnHelper OBJ = new PoCloseForWmsReturnHelper();
		
		public static PoCloseForWmsReturnHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(PoCloseForWmsReturn structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("po".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPo(value);
					}
					
					
					
					
					
					if ("saleArea".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetSaleArea(value);
					}
					
					
					
					
					
					if ("closeStatus".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetCloseStatus(value);
					}
					
					
					
					
					
					if ("operatorJobnumber".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperatorJobnumber(value);
					}
					
					
					
					
					
					if ("operatorName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperatorName(value);
					}
					
					
					
					
					
					if ("updateTime".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetUpdateTime(value);
					}
					
					
					
					
					
					if ("maxId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMaxId(value);
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
		
		
		public void Write(PoCloseForWmsReturn structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPo() != null) {
				
				oprot.WriteFieldBegin("po");
				oprot.WriteString(structs.GetPo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSaleArea() != null) {
				
				oprot.WriteFieldBegin("saleArea");
				oprot.WriteString(structs.GetSaleArea());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetCloseStatus() != null) {
				
				oprot.WriteFieldBegin("closeStatus");
				oprot.WriteI32((int)structs.GetCloseStatus()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("closeStatus can not be null!");
			}
			
			
			if(structs.GetOperatorJobnumber() != null) {
				
				oprot.WriteFieldBegin("operatorJobnumber");
				oprot.WriteString(structs.GetOperatorJobnumber());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperatorName() != null) {
				
				oprot.WriteFieldBegin("operatorName");
				oprot.WriteString(structs.GetOperatorName());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUpdateTime() != null) {
				
				oprot.WriteFieldBegin("updateTime");
				oprot.WriteString(structs.GetUpdateTime());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetMaxId() != null) {
				
				oprot.WriteFieldBegin("maxId");
				oprot.WriteI64((long)structs.GetMaxId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(PoCloseForWmsReturn bean){
			
			
		}
		
	}
	
}