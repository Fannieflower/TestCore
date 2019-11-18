using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class BatchCancelRequestHelper : TBeanSerializer<BatchCancelRequest>
	{
		
		public static BatchCancelRequestHelper OBJ = new BatchCancelRequestHelper();
		
		public static BatchCancelRequestHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(BatchCancelRequest structs, Protocol iprot){
			
			
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
					
					
					
					
					
					if ("userList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.CancelUser> value;
						
						value = new List<com.vip.svip.osp.service.CancelUser>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.CancelUser elem0;
								
								elem0 = new com.vip.svip.osp.service.CancelUser();
								com.vip.svip.osp.service.CancelUserHelper.getInstance().Read(elem0, iprot);
								
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
		
		
		public void Write(BatchCancelRequest structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBatchNo() != null) {
				
				oprot.WriteFieldBegin("batchNo");
				oprot.WriteString(structs.GetBatchNo());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetUserList() != null) {
				
				oprot.WriteFieldBegin("userList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.CancelUser _item0 in structs.GetUserList()){
					
					
					com.vip.svip.osp.service.CancelUserHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(BatchCancelRequest bean){
			
			
		}
		
	}
	
}