using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.cup.api.aftersale{
	
	
	
	public class UpdateReturnRefundResultRespHelper : TBeanSerializer<UpdateReturnRefundResultResp>
	{
		
		public static UpdateReturnRefundResultRespHelper OBJ = new UpdateReturnRefundResultRespHelper();
		
		public static UpdateReturnRefundResultRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(UpdateReturnRefundResultResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("succ_apply_ids".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<string> value;
						
						value = new List<string>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								string elem1;
								elem1 = iprot.ReadString();
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSucc_apply_ids(value);
					}
					
					
					
					
					
					if ("failed_apply_ids".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.cup.api.aftersale.FailedApply> value;
						
						value = new List<com.vip.vop.cup.api.aftersale.FailedApply>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.cup.api.aftersale.FailedApply elem2;
								
								elem2 = new com.vip.vop.cup.api.aftersale.FailedApply();
								com.vip.vop.cup.api.aftersale.FailedApplyHelper.getInstance().Read(elem2, iprot);
								
								value.Add(elem2);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetFailed_apply_ids(value);
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
		
		
		public void Write(UpdateReturnRefundResultResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetSucc_apply_ids() != null) {
				
				oprot.WriteFieldBegin("succ_apply_ids");
				
				oprot.WriteListBegin();
				foreach(string _item0 in structs.GetSucc_apply_ids()){
					
					oprot.WriteString(_item0);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailed_apply_ids() != null) {
				
				oprot.WriteFieldBegin("failed_apply_ids");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.cup.api.aftersale.FailedApply _item0 in structs.GetFailed_apply_ids()){
					
					
					com.vip.vop.cup.api.aftersale.FailedApplyHelper.getInstance().Write(_item0, oprot);
					
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
		
		
		public void Validate(UpdateReturnRefundResultResp bean){
			
			
		}
		
	}
	
}