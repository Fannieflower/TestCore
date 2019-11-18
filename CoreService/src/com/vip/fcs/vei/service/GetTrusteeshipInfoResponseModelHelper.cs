using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.fcs.vei.service{
	
	
	
	public class GetTrusteeshipInfoResponseModelHelper : TBeanSerializer<GetTrusteeshipInfoResponseModel>
	{
		
		public static GetTrusteeshipInfoResponseModelHelper OBJ = new GetTrusteeshipInfoResponseModelHelper();
		
		public static GetTrusteeshipInfoResponseModelHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetTrusteeshipInfoResponseModel structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("trusteeshipInfoModel".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.vei.service.TrusteeshipInfoModel value;
						
						value = new com.vip.fcs.vei.service.TrusteeshipInfoModel();
						com.vip.fcs.vei.service.TrusteeshipInfoModelHelper.getInstance().Read(value, iprot);
						
						structs.SetTrusteeshipInfoModel(value);
					}
					
					
					
					
					
					if ("restulMesg".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.fcs.vei.service.BaseRetMsg value;
						
						value = new com.vip.fcs.vei.service.BaseRetMsg();
						com.vip.fcs.vei.service.BaseRetMsgHelper.getInstance().Read(value, iprot);
						
						structs.SetRestulMesg(value);
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
		
		
		public void Write(GetTrusteeshipInfoResponseModel structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetTrusteeshipInfoModel() != null) {
				
				oprot.WriteFieldBegin("trusteeshipInfoModel");
				
				com.vip.fcs.vei.service.TrusteeshipInfoModelHelper.getInstance().Write(structs.GetTrusteeshipInfoModel(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetRestulMesg() != null) {
				
				oprot.WriteFieldBegin("restulMesg");
				
				com.vip.fcs.vei.service.BaseRetMsgHelper.getInstance().Write(structs.GetRestulMesg(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("restulMesg can not be null!");
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetTrusteeshipInfoResponseModel bean){
			
			
		}
		
	}
	
}