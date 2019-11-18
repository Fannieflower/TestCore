using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class CancelUserHelper : TBeanSerializer<CancelUser>
	{
		
		public static CancelUserHelper OBJ = new CancelUserHelper();
		
		public static CancelUserHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(CancelUser structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("userId".Equals(schemeField.Trim())){
						
						needSkip = false;
						long? value;
						value = iprot.ReadI64(); 
						
						structs.SetUserId(value);
					}
					
					
					
					
					
					if ("account".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetAccount(value);
					}
					
					
					
					
					
					if ("oa".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOa(value);
					}
					
					
					
					
					
					if ("vipCardAmount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetVipCardAmount(value);
					}
					
					
					
					
					
					if ("reasonList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.CancelReason> value;
						
						value = new List<com.vip.svip.osp.service.CancelReason>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.CancelReason elem0;
								
								elem0 = new com.vip.svip.osp.service.CancelReason();
								com.vip.svip.osp.service.CancelReasonHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetReasonList(value);
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
		
		
		public void Write(CancelUser structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetUserId() != null) {
				
				oprot.WriteFieldBegin("userId");
				oprot.WriteI64((long)structs.GetUserId()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetAccount() != null) {
				
				oprot.WriteFieldBegin("account");
				oprot.WriteString(structs.GetAccount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOa() != null) {
				
				oprot.WriteFieldBegin("oa");
				oprot.WriteString(structs.GetOa());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetVipCardAmount() != null) {
				
				oprot.WriteFieldBegin("vipCardAmount");
				oprot.WriteString(structs.GetVipCardAmount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetReasonList() != null) {
				
				oprot.WriteFieldBegin("reasonList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.CancelReason _item0 in structs.GetReasonList()){
					
					
					com.vip.svip.osp.service.CancelReasonHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(CancelUser bean){
			
			
		}
		
	}
	
}