using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.xstore.cc.bulkbuying.service{
	
	
	
	public class StatPoCommonRespHelper : TBeanSerializer<StatPoCommonResp>
	{
		
		public static StatPoCommonRespHelper OBJ = new StatPoCommonRespHelper();
		
		public static StatPoCommonRespHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(StatPoCommonResp structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("pagination".Equals(schemeField.Trim())){
						
						needSkip = false;
						com.vip.xstore.cc.bulkbuying.model.PaginationModel value;
						
						value = new com.vip.xstore.cc.bulkbuying.model.PaginationModel();
						com.vip.xstore.cc.bulkbuying.model.PaginationModelHelper.getInstance().Read(value, iprot);
						
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
		
		
		public void Write(StatPoCommonResp structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetPagination() != null) {
				
				oprot.WriteFieldBegin("pagination");
				
				com.vip.xstore.cc.bulkbuying.model.PaginationModelHelper.getInstance().Write(structs.GetPagination(), oprot);
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(StatPoCommonResp bean){
			
			
		}
		
	}
	
}