using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractViewSaveParamsHelper : TBeanSerializer<ProtContractViewSaveParams>
	{
		
		public static ProtContractViewSaveParamsHelper OBJ = new ProtContractViewSaveParamsHelper();
		
		public static ProtContractViewSaveParamsHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractViewSaveParams structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("mainId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetMainId(value);
					}
					
					
					
					
					
					if ("content".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetContent(value);
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
		
		
		public void Write(ProtContractViewSaveParams structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetMainId() != null) {
				
				oprot.WriteFieldBegin("mainId");
				oprot.WriteI64((long)structs.GetMainId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetContent() != null) {
				
				oprot.WriteFieldBegin("content");
				oprot.WriteString(structs.GetContent());
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractViewSaveParams bean){
			
			
		}
		
	}
	
}