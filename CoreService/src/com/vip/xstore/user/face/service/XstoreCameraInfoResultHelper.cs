using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.user.face.service{
	
	
	
	public class XstoreCameraInfoResultHelper : TBeanSerializer<XstoreCameraInfoResult>
	{
		
		public static XstoreCameraInfoResultHelper OBJ = new XstoreCameraInfoResultHelper();
		
		public static XstoreCameraInfoResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(XstoreCameraInfoResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("codeResult".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.user.face.service.common.CodeResult value;
						
						value = new com.vip.xstore.user.face.service.common.CodeResult();
						com.vip.xstore.user.face.service.common.CodeResultHelper.getInstance().Read(value, iprot);
						
						structs.SetCodeResult(value);
					}
					
					
					
					
					
					if ("xstoreCameraInfoModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.user.face.service.XstoreCameraInfoModel value;
						
						value = new com.vip.xstore.user.face.service.XstoreCameraInfoModel();
						com.vip.xstore.user.face.service.XstoreCameraInfoModelHelper.getInstance().Read(value, iprot);
						
						structs.SetXstoreCameraInfoModel(value);
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
		
		
		public void Write(XstoreCameraInfoResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetCodeResult() != null) {
				
				oprot.WriteFieldBegin("codeResult");
				
				com.vip.xstore.user.face.service.common.CodeResultHelper.getInstance().Write(structs.GetCodeResult(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetXstoreCameraInfoModel() != null) {
				
				oprot.WriteFieldBegin("xstoreCameraInfoModel");
				
				com.vip.xstore.user.face.service.XstoreCameraInfoModelHelper.getInstance().Write(structs.GetXstoreCameraInfoModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(XstoreCameraInfoResult bean){
			
			
		}
		
	}
	
}