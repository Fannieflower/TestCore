using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.vop.vcloud.invoice.api{
	
	
	
	public class QueryRefundResHelper : TBeanSerializer<QueryRefundRes>
	{
		
		public static QueryRefundResHelper OBJ = new QueryRefundResHelper();
		
		public static QueryRefundResHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(QueryRefundRes structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("refunds".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.vop.vcloud.invoice.api.Refund> value;
						
						value = new List<com.vip.vop.vcloud.invoice.api.Refund>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.vop.vcloud.invoice.api.Refund elem0;
								
								elem0 = new com.vip.vop.vcloud.invoice.api.Refund();
								com.vip.vop.vcloud.invoice.api.RefundHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetRefunds(value);
					}
					
					
					
					
					
					if ("pagination".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.vop.vcloud.common.api.Pagination value;
						
						value = new com.vip.vop.vcloud.common.api.Pagination();
						com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Read(value, iprot);
						
						structs.SetPagination(value);
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
		
		
		public void Write(QueryRefundRes structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetRefunds() != null) {
				
				oprot.WriteFieldBegin("refunds");
				
				oprot.WriteListBegin();
				foreach(com.vip.vop.vcloud.invoice.api.Refund _item0 in structs.GetRefunds()){
					
					
					com.vip.vop.vcloud.invoice.api.RefundHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetPagination() != null) {
				
				oprot.WriteFieldBegin("pagination");
				
				com.vip.vop.vcloud.common.api.PaginationHelper.getInstance().Write(structs.GetPagination(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(QueryRefundRes bean){
			
			
		}
		
	}
	
}