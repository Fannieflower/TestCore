using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.arplatform.merchModel.service{
	
	
	
	public class Jd3dModelHelper : TBeanSerializer<Jd3dModel>
	{
		
		public static Jd3dModelHelper OBJ = new Jd3dModelHelper();
		
		public static Jd3dModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(Jd3dModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pidVid".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPidVid(value);
					}
					
					
					
					
					
					if ("modelUrl".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetModelUrl(value);
					}
					
					
					
					
					
					if ("barcode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBarcode(value);
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
		
		
		public void Write(Jd3dModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPidVid() != null) {
				
				oprot.WriteFieldBegin("pidVid");
				oprot.WriteString(structs.GetPidVid());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetModelUrl() != null) {
				
				oprot.WriteFieldBegin("modelUrl");
				oprot.WriteString(structs.GetModelUrl());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("modelUrl can not be null!");
			}
			
			
			if(structs.GetBarcode() != null) {
				
				oprot.WriteFieldBegin("barcode");
				oprot.WriteString(structs.GetBarcode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("barcode can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(Jd3dModel bean){
			
			
		}
		
	}
	
}