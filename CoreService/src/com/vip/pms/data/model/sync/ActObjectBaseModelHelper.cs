using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.pms.data.model.sync{
	
	
	
	public class ActObjectBaseModelHelper : TBeanSerializer<ActObjectBaseModel>
	{
		
		public static ActObjectBaseModelHelper OBJ = new ActObjectBaseModelHelper();
		
		public static ActObjectBaseModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ActObjectBaseModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("objectId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetObjectId(value);
					}
					
					
					
					
					
					if ("pageId".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetPageId(value);
					}
					
					
					
					
					
					if ("actType".Equals(schemeField.Trim())){
						
						needSkip = false;
						int value;
						value = iprot.ReadI32(); 
						
						structs.SetActType(value);
					}
					
					
					
					
					
					if ("actName".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActName(value);
					}
					
					
					
					
					
					if ("actNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActNo(value);
					}
					
					
					
					
					
					if ("actMainNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetActMainNo(value);
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
		
		
		public void Write(ActObjectBaseModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetObjectId() != null) {
				
				oprot.WriteFieldBegin("objectId");
				oprot.WriteI64((long)structs.GetObjectId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("objectId can not be null!");
			}
			
			
			if(structs.GetPageId() != null) {
				
				oprot.WriteFieldBegin("pageId");
				oprot.WriteI32((int)structs.GetPageId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("pageId can not be null!");
			}
			
			
			if(structs.GetActType() != null) {
				
				oprot.WriteFieldBegin("actType");
				oprot.WriteI32((int)structs.GetActType()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actType can not be null!");
			}
			
			
			if(structs.GetActName() != null) {
				
				oprot.WriteFieldBegin("actName");
				oprot.WriteString(structs.GetActName());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("actName can not be null!");
			}
			
			
			if(structs.GetActNo() != null) {
				
				oprot.WriteFieldBegin("actNo");
				oprot.WriteString(structs.GetActNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetActMainNo() != null) {
				
				oprot.WriteFieldBegin("actMainNo");
				oprot.WriteString(structs.GetActMainNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ActObjectBaseModel bean){
			
			
		}
		
	}
	
}