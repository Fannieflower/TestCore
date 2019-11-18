using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.api.promotion.vis.protcontract.service{
	
	
	
	public class ProtContractDetailQueryParamsHelper : TBeanSerializer<ProtContractDetailQueryParams>
	{
		
		public static ProtContractDetailQueryParamsHelper OBJ = new ProtContractDetailQueryParamsHelper();
		
		public static ProtContractDetailQueryParamsHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(ProtContractDetailQueryParams structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pager".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.common.Pager value;
						
						value = new com.vip.api.promotion.vis.common.Pager();
						com.vip.api.promotion.vis.common.PagerHelper.getInstance().Read(value, iprot);
						
						structs.SetPager(value);
					}
					
					
					
					
					
					if ("protContractDetailQueryParam".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParam value;
						
						value = new com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParam();
						com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParamHelper.getInstance().Read(value, iprot);
						
						structs.SetProtContractDetailQueryParam(value);
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
		
		
		public void Write(ProtContractDetailQueryParams structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPager() != null) {
				
				oprot.WriteFieldBegin("pager");
				
				com.vip.api.promotion.vis.common.PagerHelper.getInstance().Write(structs.GetPager(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			if(structs.GetProtContractDetailQueryParam() != null) {
				
				oprot.WriteFieldBegin("protContractDetailQueryParam");
				
				com.vip.api.promotion.vis.protcontract.service.ProtContractDetailQueryParamHelper.getInstance().Write(structs.GetProtContractDetailQueryParam(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(ProtContractDetailQueryParams bean){
			
			
		}
		
	}
	
}