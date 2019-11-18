using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.logistics.carrier.service{
	
	
	
	public class LoadingListRespHelper : TBeanSerializer<LoadingListResp>
	{
		
		public static LoadingListRespHelper OBJ = new LoadingListRespHelper();
		
		public static LoadingListRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(LoadingListResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("batch_no".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBatch_no(value);
					}
					
					
					
					
					
					if ("loading_item_process_results".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.logistics.carrier.service.LoadingItemProcessResult> value;
						
						value = new List<com.vip.vop.logistics.carrier.service.LoadingItemProcessResult>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.logistics.carrier.service.LoadingItemProcessResult elem1;
								
								elem1 = new com.vip.vop.logistics.carrier.service.LoadingItemProcessResult();
								com.vip.vop.logistics.carrier.service.LoadingItemProcessResultHelper.getInstance().Read(elem1, iprot);
								
								value.Add(elem1);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetLoading_item_process_results(value);
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
		
		
		public void Write(LoadingListResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBatch_no() != null) {
				
				oprot.WriteFieldBegin("batch_no");
				oprot.WriteString(structs.GetBatch_no());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetLoading_item_process_results() != null) {
				
				oprot.WriteFieldBegin("loading_item_process_results");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.logistics.carrier.service.LoadingItemProcessResult _item0 in structs.GetLoading_item_process_results()){
					
					
					com.vip.vop.logistics.carrier.service.LoadingItemProcessResultHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(LoadingListResp bean){
			
			
		}
		
	}
	
}