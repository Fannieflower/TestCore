using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractSubmitParamHelper : TBeanSerializer<ProtContractSubmitParam>
	{
		
		public static ProtContractSubmitParamHelper OBJ = new ProtContractSubmitParamHelper();
		
		public static ProtContractSubmitParamHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractSubmitParam structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("id".Equals(schemeField.Trim())){
						
						needSkip = false;
						long value;
						value = iprot.ReadI64(); 
						
						structs.SetId(value);
					}
					
					
					
					
					
					if ("checkCaptchaParam".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.CheckCaptchaParam value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.CheckCaptchaParam();
						com.vip.api.promotion.vis.protcontract.service.CheckCaptchaParamHelper.getInstance().Read(value, iprot);
						
						structs.SetCheckCaptchaParam(value);
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
		
		
		public void Write(ProtContractSubmitParam structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetId() != null) {
				
				oprot.WriteFieldBegin("id");
				oprot.WriteI64((long)structs.GetId()); 
				
				oprot.WriteFieldEnd();
			}
			
			else{
				throw new ArgumentException("id can not be null!");
			}
			
			
			if(structs.GetCheckCaptchaParam() != null) {
				
				oprot.WriteFieldBegin("checkCaptchaParam");
				
				com.vip.api.promotion.vis.protcontract.service.CheckCaptchaParamHelper.getInstance().Write(structs.GetCheckCaptchaParam(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractSubmitParam bean){
			
			
		}
		
	}
	
}