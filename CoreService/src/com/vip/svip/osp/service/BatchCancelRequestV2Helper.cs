using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class BatchCancelRequestV2Helper : TBeanSerializer<BatchCancelRequestV2>
	{
		
		public static BatchCancelRequestV2Helper OBJ = new BatchCancelRequestV2Helper();
		
		public static BatchCancelRequestV2Helper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BatchCancelRequestV2 structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("batchNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBatchNo(value);
					}
					
					
					
					
					
					if ("oaAccount".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOaAccount(value);
					}
					
					
					
					
					
					if ("oaNo".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOaNo(value);
					}
					
					
					
					
					
					if ("operator".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetOperator(value);
					}
					
					
					
					
					
					if ("userList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.CancelUserV2> value;
						
						value = new List<com.vip.svip.osp.service.CancelUserV2>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.CancelUserV2 elem0;
								
								elem0 = new com.vip.svip.osp.service.CancelUserV2();
								com.vip.svip.osp.service.CancelUserV2Helper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetUserList(value);
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
		
		
		public void Write(BatchCancelRequestV2 structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBatchNo() != null) {
				
				oprot.WriteFieldBegin("batchNo");
				oprot.WriteString(structs.GetBatchNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOaAccount() != null) {
				
				oprot.WriteFieldBegin("oaAccount");
				oprot.WriteString(structs.GetOaAccount());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOaNo() != null) {
				
				oprot.WriteFieldBegin("oaNo");
				oprot.WriteString(structs.GetOaNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetOperator() != null) {
				
				oprot.WriteFieldBegin("operator");
				oprot.WriteString(structs.GetOperator());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserList() != null) {
				
				oprot.WriteFieldBegin("userList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.CancelUserV2 _item0 in structs.GetUserList()){
					
					
					com.vip.svip.osp.service.CancelUserV2Helper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BatchCancelRequestV2 bean){
			
			
		}
		
	}
	
}