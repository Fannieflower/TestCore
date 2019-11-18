using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.top.carrier.bizservice{
	
	
	
	public class SortingInfoResultHelper : TBeanSerializer<SortingInfoResult>
	{
		
		public static SortingInfoResultHelper OBJ = new SortingInfoResultHelper();
		
		public static SortingInfoResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(SortingInfoResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("batchno".Equals(schemeField.Trim())){
						
						needSkip = false;
						string value;
						value = iprot.ReadString();
						
						structs.SetBatchno(value);
					}
					
					
					
					
					
					if ("totalCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetTotalCount(value);
					}
					
					
					
					
					
					if ("successCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetSuccessCount(value);
					}
					
					
					
					
					
					if ("failCount".Equals(schemeField.Trim())){
						
						needSkip = false;
						int? value;
						value = iprot.ReadI32(); 
						
						structs.SetFailCount(value);
					}
					
					
					
					
					
					if ("sortingInfoResponseItems".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.top.carrier.bizservice.SortingInfoResponseItem> value;
						
						value = new List<com.vip.top.carrier.bizservice.SortingInfoResponseItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.top.carrier.bizservice.SortingInfoResponseItem elem0;
								
								elem0 = new com.vip.top.carrier.bizservice.SortingInfoResponseItem();
								com.vip.top.carrier.bizservice.SortingInfoResponseItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetSortingInfoResponseItems(value);
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
		
		
		public void Write(SortingInfoResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetBatchno() != null) {
				
				oprot.WriteFieldBegin("batchno");
				oprot.WriteString(structs.GetBatchno());
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetTotalCount() != null) {
				
				oprot.WriteFieldBegin("totalCount");
				oprot.WriteI32((int)structs.GetTotalCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSuccessCount() != null) {
				
				oprot.WriteFieldBegin("successCount");
				oprot.WriteI32((int)structs.GetSuccessCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetFailCount() != null) {
				
				oprot.WriteFieldBegin("failCount");
				oprot.WriteI32((int)structs.GetFailCount()); 
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetSortingInfoResponseItems() != null) {
				
				oprot.WriteFieldBegin("sortingInfoResponseItems");
				
				oprot.WriteListBegin();
				foreach(com.vip.top.carrier.bizservice.SortingInfoResponseItem _item0 in structs.GetSortingInfoResponseItems()){
					
					
					com.vip.top.carrier.bizservice.SortingInfoResponseItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(SortingInfoResult bean){
			
			
		}
		
	}
	
}