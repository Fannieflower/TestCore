using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraInfoUpdateParamHelper : TBeanSerializer<XstoreCameraInfoUpdateParam>
	{
		
		public static XstoreCameraInfoUpdateParamHelper OBJ = new XstoreCameraInfoUpdateParamHelper();
		
		public static XstoreCameraInfoUpdateParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraInfoUpdateParam structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("posCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetPosCode(value);
					}
					
					
					
					
					
					if ("cameraCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetCameraCode(value);
					}
					
					
					
					
					
					if ("storeCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetStoreCode(value);
					}
					
					
					
					
					
					if ("txRegionCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTxRegionCode(value);
					}
					
					
					
					
					
					if ("txStoreCode".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetTxStoreCode(value);
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
		
		
		public void Write(XstoreCameraInfoUpdateParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPosCode() != null) {
				
				oprot.WriteFieldBegin("posCode");
				oprot.WriteString(structs.GetPosCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("posCode can not be null!");
			}
			
			
			if(structs.GetCameraCode() != null) {
				
				oprot.WriteFieldBegin("cameraCode");
				oprot.WriteString(structs.GetCameraCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("cameraCode can not be null!");
			}
			
			
			if(structs.GetStoreCode() != null) {
				
				oprot.WriteFieldBegin("storeCode");
				oprot.WriteString(structs.GetStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("storeCode can not be null!");
			}
			
			
			if(structs.GetTxRegionCode() != null) {
				
				oprot.WriteFieldBegin("txRegionCode");
				oprot.WriteString(structs.GetTxRegionCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("txRegionCode can not be null!");
			}
			
			
			if(structs.GetTxStoreCode() != null) {
				
				oprot.WriteFieldBegin("txStoreCode");
				oprot.WriteString(structs.GetTxStoreCode());
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("txStoreCode can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraInfoUpdateParam bean){
			
			
		}
		
	}
	
}