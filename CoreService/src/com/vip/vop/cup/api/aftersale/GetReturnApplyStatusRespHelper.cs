using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.aftersale{
	
	
	
	public class GetReturnApplyStatusRespHelper : TBeanSerializer<GetReturnApplyStatusResp>
	{
		
		public static GetReturnApplyStatusRespHelper OBJ = new GetReturnApplyStatusRespHelper();
		
		public static GetReturnApplyStatusRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetReturnApplyStatusResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("return_apply_status_info".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfo> value;
						
						value = new List<com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfo>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfo elem0;
								
								elem0 = new com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfo();
								com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfoHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetReturn_apply_status_info(value);
					}
					
					
					
					
					
					if ("result".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.cup.api.aftersale.Result value;
						
						value = new com.vip.vop.cup.api.aftersale.Result();
						com.vip.vop.cup.api.aftersale.ResultHelper.getInstance().Read(value, iprot);
						
						structs.SetResult(value);
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
		
		
		public void Write(GetReturnApplyStatusResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetReturn_apply_status_info() != null) {
				
				oprot.WriteFieldBegin("return_apply_status_info");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfo _item0 in structs.GetReturn_apply_status_info()){
					
					
					com.vip.vop.cup.api.aftersale.ReturnApplyStatusInfoHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetResult() != null) {
				
				oprot.WriteFieldBegin("result");
				
				com.vip.vop.cup.api.aftersale.ResultHelper.getInstance().Write(structs.GetResult(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetReturnApplyStatusResp bean){
			
			
		}
		
	}
	
}