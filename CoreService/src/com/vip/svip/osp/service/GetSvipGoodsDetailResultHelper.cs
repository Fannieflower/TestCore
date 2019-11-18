using System;
using System.Collections.Generic;
using System.Text;
using Osp.Sdk.Base;
using Osp.Sdk.Protocol;
using Osp.Sdk.Exception;
namespace com.vip.svip.osp.service{
	
	
	
	public class GetSvipGoodsDetailResultHelper : TBeanSerializer<GetSvipGoodsDetailResult>
	{
		
		public static GetSvipGoodsDetailResultHelper OBJ = new GetSvipGoodsDetailResultHelper();
		
		public static GetSvipGoodsDetailResultHelper getInstance() {
			
			return OBJ;
		}
		
		
		public void Read(GetSvipGoodsDetailResult structs, Protocol iprot){
			
			
			String schemeStruct = iprot.ReadStructBegin();
			if(schemeStruct != null){
				
				while(true){
					
					String schemeField = iprot.ReadFieldBegin();
					if (schemeField == null) break;
					bool needSkip = true;
					
					
					if ("goodsList".Equals(schemeField.Trim())){
						
						needSkip = false;
						List<com.vip.svip.osp.service.SvipGoodsDetailItem> value;
						
						value = new List<com.vip.svip.osp.service.SvipGoodsDetailItem>();
						iprot.ReadListBegin();
						while(true){
							
							try{
								
								com.vip.svip.osp.service.SvipGoodsDetailItem elem0;
								
								elem0 = new com.vip.svip.osp.service.SvipGoodsDetailItem();
								com.vip.svip.osp.service.SvipGoodsDetailItemHelper.getInstance().Read(elem0, iprot);
								
								value.Add(elem0);
							}
							catch(Exception e){
								
								
								break;
							}
						}
						
						iprot.ReadListEnd();
						
						structs.SetGoodsList(value);
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
		
		
		public void Write(GetSvipGoodsDetailResult structs, Protocol oprot){
			
			Validate(structs);
			oprot.WriteStructBegin();
			
			if(structs.GetGoodsList() != null) {
				
				oprot.WriteFieldBegin("goodsList");
				
				oprot.WriteListBegin();
				foreach(com.vip.svip.osp.service.SvipGoodsDetailItem _item0 in structs.GetGoodsList()){
					
					
					com.vip.svip.osp.service.SvipGoodsDetailItemHelper.getInstance().Write(_item0, oprot);
					
				}
				
				oprot.WriteListEnd();
				
				oprot.WriteFieldEnd();
			}
			
			
			oprot.WriteFieldStop();
			oprot.WriteStructEnd();
		}
		
		
		public void Validate(GetSvipGoodsDetailResult bean){
			
			
		}
		
	}
	
}